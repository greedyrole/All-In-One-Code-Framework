=============================================================================
                    Windows Application: VBCpuUsage
=============================================================================

/////////////////////////////////////////////////////////////////////////////
Summary:

This sample demonstrates how to use PerformanceCounter to get the CPU Usage 
with the following features:

1. The Total Processor Time.
2. The Processor time of a specific process.
3. Draw the CPU Usage History like Task Manager.


/////////////////////////////////////////////////////////////////////////////
Demo:

Step1. Open this project in Visual Studio 2010.

Step2. Build the project and run VBCpuUsage.exe.

Step3. Check "Display total CPU Usage" and "Display the CPU Usage of a process". Click the 
       ComboBox and select a process (i.e. taskmgr, if Task Manager is running.) to monitor.

       You will see 2 charts on this application that display the CPU usage history.


/////////////////////////////////////////////////////////////////////////////
Code Logic:

A. Design the CpuUsageMonitorBase class that supplies basic fields/events/functions/interfaces 
   of the monitors, such as Timer, PerformanceCounter and IDisposable interface.

   This is an abstract class, so CpuUsageMonitorBase class cannot be instantiated. When the
   child classes are instantiated, they have to pass the categoryName, counterName and instanceName
   to the constructor of CpuUsageMonitorBase class to initialize the performance counter.
   
         Me._cpuPerformanceCounter =
            New PerformanceCounter(categoryName, counterName, instanceName)
    
   The timer is used to get the performance counter value every few seconds, and raise the 
   CpuUsageValueArrayChanged event. If there is any exception while reading the performance 
   counter value, the ErrorOccurred event will be raised. 
     

B. Design the TotalCpuUsageMonitor class that is used to monitor the total CPU usage. It inherits
   the CpuUsageMonitorBase class, and defines 3 constants:

        Private Const _categoryName As String = "Processor"
        Private Const _counterName As String = "% Processor Time"
        Private Const _instanceName As String = "_Total"

   To get the total CPU usage, we can use above constants to initialize a performance counter.
    
        Public Sub New(ByVal timerPeriod As Integer, ByVal valueArrayCapacity As Integer)
            MyBase.New(timerPeriod, valueArrayCapacity, _categoryName,
                       _counterName, _instanceName)
        End Sub

C. Design the ProcessCpuUsageMonitor class that is used to monitor the CPU usage of a 
   specified process. It also inherits the CpuUsageMonitorBase class, and defines 2 constants:
        
        Private Const _categoryName As String = "Process"
        Private Const _counterName As String = "% Processor Time"
   
   To initialize a performance counter, we still need the instance name (a process name). So this 
   class also supplies a method to get available processes.

        Private Shared _category As PerformanceCounterCategory
        Public Shared ReadOnly Property Category() As PerformanceCounterCategory
            Get
                If _category Is Nothing Then
                    _category = New PerformanceCounterCategory(_categoryName)
                End If
                Return _category
            End Get
        End Property
               
        Public Shared Function GetAvailableProcesses() As String()
            Return Category.GetInstanceNames().OrderBy(Function(name) name).ToArray()
        End Function


D. Design the MainForm that initializes the totalCpuUsageMonitor and processCpuUsageMonitor,
   registers the CpuUsageValueArrayChanged and display the CPU usage history in the charts.

        ''' <summary>
        ''' Invoke the processCpuUsageMonitor_CpuUsageValueArrayChangedHandler to handle
        ''' the CpuUsageValueArrayChanged event of processCpuUsageMonitor.
        ''' </summary>
        Private Sub processCpuUsageMonitor_CpuUsageValueArrayChanged(ByVal sender As Object,
                                                                     ByVal e As CpuUsageValueArrayChangedEventArg)
            Me.Invoke(New EventHandler(Of CpuUsageValueArrayChangedEventArg)(
                      AddressOf processCpuUsageMonitor_CpuUsageValueArrayChangedHandler), sender, e)
        End Sub
        
        Private Sub processCpuUsageMonitor_CpuUsageValueArrayChangedHandler(ByVal sender As Object,
                                                                            ByVal e As CpuUsageValueArrayChangedEventArg)
            Dim processCpuUsageSeries = chartProcessCupUsage.Series("ProcessCpuUsageSeries")
            Dim values = e.Values
        
            ' Display the process CPU usage in the chart.
            processCpuUsageSeries.Points.DataBindY(e.Values)
        
        End Sub
             
        
        ''' <summary>
        ''' Invoke the totalCpuUsageMonitor_CpuUsageValueArrayChangedHandler to handle
        ''' the CpuUsageValueArrayChanged event of processCpuUsageMonitor.
        ''' </summary>
        Private Sub totalCpuUsageMonitor_CpuUsageValueArrayChanged(ByVal sender As Object,
                                                                   ByVal e As CpuUsageValueArrayChangedEventArg)
            Me.Invoke(New EventHandler(Of CpuUsageValueArrayChangedEventArg)(
                      AddressOf totalCpuUsageMonitor_CpuUsageValueArrayChangedHandler), sender, e)
        End Sub
        Private Sub totalCpuUsageMonitor_CpuUsageValueArrayChangedHandler(ByVal sender As Object,
                                                                          ByVal e As CpuUsageValueArrayChangedEventArg)
            Dim totalCpuUsageSeries = chartTotalCpuUsage.Series("TotalCpuUsageSeries")
            Dim values = e.Values
        
            ' Display the total CPU usage in the chart.
            totalCpuUsageSeries.Points.DataBindY(e.Values)
        
        End Sub
        
      
  If there is any error while reading the performance counter value, the UI will also handle
  this event. 

        ''' <summary>
        ''' Invoke the processCpuUsageMonitor_ErrorOccurredHandler to handle
        ''' the ErrorOccurred event of processCpuUsageMonitor.
        ''' </summary>
        Private Sub processCpuUsageMonitor_ErrorOccurred(ByVal sender As Object,
                                                         ByVal e As ErrorEventArgs)
            Me.Invoke(New EventHandler(Of ErrorEventArgs)(
                      AddressOf processCpuUsageMonitor_ErrorOccurredHandler), sender, e)
        End Sub
        
        Private Sub processCpuUsageMonitor_ErrorOccurredHandler(ByVal sender As Object,
                                                                ByVal e As ErrorEventArgs)
            If _processCpuUsageMonitor IsNot Nothing Then
                _processCpuUsageMonitor.Dispose()
                _processCpuUsageMonitor = Nothing
        
                Dim processCpuUsageSeries = chartProcessCupUsage.Series("ProcessCpuUsageSeries")
                processCpuUsageSeries.Points.Clear()
            End If
            MessageBox.Show(e.Error.Message)
        End Sub

         ''' <summary>
        ''' Invoke the totalCpuUsageMonitor_ErrorOccurredHandler to handle
        ''' the ErrorOccurred event of totalCpuUsageMonitor.
        ''' </summary>
        Private Sub totalCpuUsageMonitor_ErrorOccurred(ByVal sender As Object,
                                                       ByVal e As ErrorEventArgs)
            Me.Invoke(New EventHandler(Of ErrorEventArgs)(
                      AddressOf totalCpuUsageMonitor_ErrorOccurredHandler), sender, e)
        End Sub
        
        Private Sub totalCpuUsageMonitor_ErrorOccurredHandler(ByVal sender As Object,
                                                              ByVal e As ErrorEventArgs)
            If _totalCpuUsageMonitor IsNot Nothing Then
                _totalCpuUsageMonitor.Dispose()
                _totalCpuUsageMonitor = Nothing
        
                Dim totalCpuUsageSeries = chartTotalCpuUsage.Series("TotalCpuUsageSeries")
                totalCpuUsageSeries.Points.Clear()
            End If
            MessageBox.Show(e.Error.Message)
        End Sub


/////////////////////////////////////////////////////////////////////////////
References:

PerformanceCounter Class
http://msdn.microsoft.com/en-us/library/system.diagnostics.performancecounter.aspx

Chart Class
http://msdn.microsoft.com/en-us/library/system.windows.forms.datavisualization.charting.chart.aspx


/////////////////////////////////////////////////////////////////////////////