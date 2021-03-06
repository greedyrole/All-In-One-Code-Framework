========================================================================
    WINDOWS SERVICE : CSWin7TriggerStartService Project Overview
========================================================================

/////////////////////////////////////////////////////////////////////////////
Summary:

Services and background processes have tremendous influence on the overall 
performance of the system. If we could just cut down on the total number of 
services, we would reduce the total power consumption and increase the 
overall stability of the system. The Windows 7 Service Control Manager has 
been extended so that a service can be automatically started and stopped when 
a specific system event, or trigger, occurs on the system. The new mechanism 
is called Service Trigger Event. A service can register to be started or 
stopped when a trigger event occurs. This eliminates the need for services to 
start when the system starts, or for services to poll or actively wait for an 
event; a service can start when it is needed, instead of starting 
automatically whether or not there is work to do. Examples of predefined 
trigger events include arrival of a device of a specified device interface 
class or availability of a particular firewall port. A service can also 
register for a custom trigger event generated by an Event Tracing for Windows 
(ETW) provider.

This Visual C# code sample shows how to create a trigger-start service that 
starts when a generic USB disk becomes available. The sample also shows how 
to create a trigger-start service that starts a service when the first IP 
address on the TCP/IP networking stack becomes available, and stops a service 
when the last IP address on the TCP/IP networking stack becomes unavailable. 
These start and stop events are reported in the Application log.


/////////////////////////////////////////////////////////////////////////////
Prerequisite:

Windows 7
http://www.microsoft.com/windows/windows-7/
You must run this code sample on a Windows Server 2008 R2 or Windows 7-based 
computer. Service trigger events are not supported until Windows Server 2008 
R2 and Windows 7.


/////////////////////////////////////////////////////////////////////////////
Demo:

The following steps walk through a demonstration of the trigger start service 
sample that starts when a generic USB disk becomes available.

Step1. After you successfully build the sample project in Visual Studio 2008, 
you will get a service application: CSWin7TriggerStartService.exe. 

Step2. Run Visual Studio 2008 Command Prompt as administrator, navigate to 
the output folder of the sample project, and enter the following command to 
install the service.

  InstallUtil.exe CSWin7TriggerStartService.exe

The service is successfully installed if the process outputs:

  Beginning the Install phase of the installation.
  ......
  Installing service CSWin7TriggerStartService...
  Service CSWin7TriggerStartService has been successfully installed.
  Creating EventLog source CSWin7TriggerStartService in log Application...
  Configuring trigger-start service...
  The Install phase completed successfully, and the Commit phase is beginning.
  ......
  The Commit phase completed successfully.
  The transacted install has completed.

If you do not see this output, please look for the 
CSWin7TriggerStartService.InstallLog file in the ouput folder, and 
investigate the cause of failure.

Step3. Open Service Management Console (services.msc). You should be able to 
find "CSWin7TriggerStartService Sample Service" in the service list. 

Step4. Plug in a generic USB disk to the computer, and refresh the service 
status in Service Management Console after a short while. You would find that 
CSWin7TriggerStartService Sample Service is trigger-started. Open Event 
Viewer, and navigate to Windows Logs / Application. You should be able to see 
two events from CSWin7TriggerStartService with event messages: 
"CSWin7TriggerStartService is in OnStart." and "Service started successfully.".

Step5. To stop and uninstall the service, enter the following command in 
Visual Studio 2008 Command Prompt running as administrator.

  InstallUtil /u CSWin7TriggerStartService.exe

If the service is successfully stopped and removed, you would see this output:

  The uninstall is beginning.
  ......
  Removing EventLog source CSWin7TriggerStartService.
  Service CSWin7TriggerStartService is being removed from the system...
  Service CSWin7TriggerStartService was successfully removed from the system.
  The uninstall has completed.

------------------------

To demonstrate a trigger-start service that starts a service when the first 
IP address on the TCP/IP networking stack becomes available, and stops a 
service when the last IP address on the TCP/IP networking stack becomes 
unavailable. Please make these changes to step1 and step4 in the above demo.

Step1. In ProjectInstall.cs, comment out the codes:

	ServiceTriggerStart.SetServiceTriggerStartOnUSBArrival(
		this.serviceInstaller1.ServiceName);

and uncomment the following codes:

	ServiceTriggerStart.SetServiceTriggerStartOnIPAddressArrival(
		this.serviceInstaller1.ServiceName);

Then rebuild the sample project. 

...

Step4. Disconnect the computer from network. Make sure that the 
CSWin7TriggerStartService service is stopped at the moment. Plug in your 
network cable and refresh the service status in Service Management Console 
after the network is connected. You should find that the service is 
trigger-started. Next, unplug the network cable from your computer. You 
would see that the service is trigger-stopped in the meantime the network is 
disconnected.

...


/////////////////////////////////////////////////////////////////////////////
Deployment:

A. Setup

Installutil.exe CSWin7TriggerStartService.exe
It installs CSWin7TriggerStartService.exe into SCM as a Windows Service. If 
the current operating system support trigger-start service, the command 
prompt outputs "Configuring trigger-start service...", otherwise, it prints 
"The current system does not support trigger-start service.".

B. Cleanup

Installutil.exe /u CSWin7TriggerStartService.exe
It uninstalls CSWin7TriggerStartService from SCM.


/////////////////////////////////////////////////////////////////////////////
Creation:

A. Creating an ordinary Windows Service project

Step1. In Visual Studio 2008, add a new Visual C# / Windows / Windows Service 
project named CSWin7TriggerStartService.

Step2. Rename the default Service1 to the generic name "Service". Open the 
service in designer and set the ServiceName property to be 
CSWin7TriggerStartService. 

Step3. Drag and drop an event log component from toolbox to the design view 
of the service, and set its Log property to be Application, and its Source to 
be CSWin7TriggerStartService. The event log component will be used to log 
some application messages in the OnStart and OnStop functions of the service:

	protected override void OnStart(string[] args)
	{
		this.eventLog1.WriteEntry("CSWin7TriggerStartService is in OnStart.");
	}

	protected override void OnStop()
	{
		this.eventLog1.WriteEntry("CSWin7TriggerStartService is in OnStop.");
	}

Step4. Right-click in the design view of the service, and select Add 
Installer on the context menu. This creates the project installer components: 

	serviceProcessInstaller1
	serviceInstaller1

Set the Account property of serviceProcessInstaller1 to be Local Service, so 
the service will be run as Local Service. As for serviceInstaller1, make its 
ServiceName property "CSWin7TriggerStartService", and make its DisplayName 
"CSWin7TriggerStartService Sample Service". Keep everything else the default 
value.

B. Adding P/Invoke signatures for native APIs and structs related to SCM

Add a NativeMethods.cs file and define P/Invoke signatures for native APIs 
like ChangeServiceConfig2, QueryServiceConfig2 and the related structs and 
enumerations.

C. Configuring the service to trigger-start when a generic USB disk becomes 
available (or trigger-start when the first IP address becomes available, and 
trigger-stop when the last IP address becomes unavailable.)

Services can be registered as trigger-start from the sc.exe command line 
utility (using the sc triggerinfo command and need to run the Command Shell 
as Administrator), or using the ChangeServiceConfig2 API programmatically. 
The service installer utility of .NET Windows Services (InstallUtil) does not 
support triggerinfo switch, so we do it programmatically. ServiceInstaller's  
AfterInstall event allows us to execute some codes after the serivce is 
installed. We are going to register the service as trigger-start in this 
event handler.

Step1. Add the helper class ServiceTriggerStart.cs to wrap and exposes some 
useful functions related to trigger start service.

  ServiceTriggerStart.IsSupported 
    Check whether the current system supports service trigger start. Service 
    trigger events are not supported until Windows Server 2008 R2 and Windows 
    7. Wndows Server 2008 R2 and Windows 7 have major version 6 and minor 
    version 1.

  ServiceTriggerStart.IsTriggerStartService
    Determine whether the specified service is configured to trigger start.
  
  ServiceTriggerStart.SetServiceTriggerStartOnUSBArrival
    Set the service to trigger-start when a generic USB disk becomes 
    available.
  
  ServiceTriggerStart.SetServiceTriggerStartOnIPAddressArrival
    Set the service to trigger-start when the first IP address on the TCP/IP 
    networking stack becomes available, and trigger-stop when the last IP 
    address on the TCP/IP networking stack becomes unavailable.

Take SetServiceTriggerStartOnUSBArrival as an example. The function modifies 
service configuration by calling the Win32 API ChangeServiceConfig2 to set 
service trigger start on USB arrival.

  1. Allocate a SERVICE_TRIGGER_SPECIFIC_DATA_ITEM structure
     a) Set its dwDataType member to SERVICE_TRIGGER_DATA_TYPE_STRING
     b) Set its cbData member to the length of the string L"USBSTOR\\GenDisk" 
        in bytes
     c) Set its pData member to that string.
  2. Allocate a SERVICE_TRIGGER structure
     a) Set its dwTriggerType member to 
        SERVICE_TRIGGER_TYPE_DEVICE_INTERFACE_ARRIVAL
     b) Set its dwAction member to SERVICE_TRIGGER_ACTION_SERVICE_START
     c) Set its pTriggerSubtype member to the address of the 
        GUID_DEVINTERFACE_DISK GUID
     d) Set its cDataItems member to 1 and its pDataItems member to the 
        address of the structure allocated in the previous step.
  3. Allocate a SERVICE_TRIGGER_INFO structure
     a) Set its cTriggers member to 1 and its pTriggers member to the address 
        of the structure allocated in the previous step.
  4. Call the ChangeServiceConfig2 function with the 
     SERVICE_CONFIG_TRIGGER_INFO information level and pass to it the address 
     of the structure allocated in the previous step. 

Please note that the above data structures are initially allocated on managed 
heap. We need to marshal them to the native memory by calling 
Marshal.AllocHGlobal and Marshal.StructureToPtr, and free the native memory 
after use (Marshal.FreeHGlobal).

The complete code of setting service tigger start on USB arrival is:

	IntPtr pGuidUSBDevice = IntPtr.Zero;
	IntPtr pUSBHardwareId = IntPtr.Zero;
	IntPtr pDeviceData = IntPtr.Zero;
	IntPtr pServiceTrigger = IntPtr.Zero;
	IntPtr pServiceTriggerInfo = IntPtr.Zero;

	try
	{
		// Marshal the Guid struct GUID_DEVINTERFACE_DISK to native memory

		pGuidUSBDevice = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Guid)));
		Marshal.StructureToPtr(GUID_DEVINTERFACE_DISK, pGuidUSBDevice, false);

		// Allocate and set the SERVICE_TRIGGER_SPECIFIC_DATA_ITEM structure

		SERVICE_TRIGGER_SPECIFIC_DATA_ITEM deviceData;
		deviceData.dwDataType =
			ServiceTriggerDataType.SERVICE_TRIGGER_DATA_TYPE_STRING;
		deviceData.cbData = (uint)(USBHardwareId.Length + 1) * 2;
		pUSBHardwareId = Marshal.StringToHGlobalUni(USBHardwareId);
		deviceData.pData = pUSBHardwareId;

		// Marshal SERVICE_TRIGGER_SPECIFIC_DATA_ITEM to native memory

		int cbDataItem = Marshal.SizeOf(typeof(SERVICE_TRIGGER_SPECIFIC_DATA_ITEM));
		pDeviceData = Marshal.AllocHGlobal(cbDataItem);
		Marshal.StructureToPtr(deviceData, pDeviceData, false);

		// Allocate and set the SERVICE_TRIGGER structure

		SERVICE_TRIGGER serviceTrigger = new SERVICE_TRIGGER();
		serviceTrigger.dwTriggerType =
			ServiceTriggerType.SERVICE_TRIGGER_TYPE_DEVICE_INTERFACE_ARRIVAL;
		serviceTrigger.dwAction =
			ServiceTriggerAction.SERVICE_TRIGGER_ACTION_SERVICE_START;
		serviceTrigger.pTriggerSubtype = pGuidUSBDevice;
		serviceTrigger.cDataItems = 1;
		serviceTrigger.pDataItems = pDeviceData;

		// Marshal the SERVICE_TRIGGER struct to native memory

		int cbServiceTrigger = Marshal.SizeOf(typeof(SERVICE_TRIGGER));
		pServiceTrigger = Marshal.AllocHGlobal(cbServiceTrigger);
		Marshal.StructureToPtr(serviceTrigger, pServiceTrigger, false);

		// Allocate and set the SERVICE_TRIGGER_INFO structure

		SERVICE_TRIGGER_INFO serviceTriggerInfo = new SERVICE_TRIGGER_INFO();
		serviceTriggerInfo.cTriggers = 1;
		serviceTriggerInfo.pTriggers = pServiceTrigger;

		// Marshal the SERVICE_TRIGGER_INFO struct to native memory

		int cbServiceTriggerInfo = Marshal.SizeOf(typeof(SERVICE_TRIGGER_INFO));
		pServiceTriggerInfo = Marshal.AllocHGlobal(cbServiceTriggerInfo);
		Marshal.StructureToPtr(serviceTriggerInfo, pServiceTriggerInfo, false);

		// Call ChangeServiceConfig2 with the SERVICE_CONFIG_TRIGGER_INFO level 
		// and pass to it the address of the SERVICE_TRIGGER_INFO structure

		if (!NativeMethods.ChangeServiceConfig2(hService,
			ServiceConfig2InfoLevel.SERVICE_CONFIG_TRIGGER_INFO,
			pServiceTriggerInfo))
		{
			// If the handle is invalid, get the last Win32 error and throw a 
			// Win32Exception
			Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
		}
	}
	finally
	{
		// Clean up the native memory

		if (pGuidUSBDevice != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(pGuidUSBDevice);
		}

		if (pUSBHardwareId != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(pUSBHardwareId);
		}

		if (pDeviceData != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(pDeviceData);
		}

		if (pServiceTrigger != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(pServiceTrigger);
		}

		if (pServiceTriggerInfo != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(pServiceTriggerInfo);
		}
	}

Please note that, in the above code, the service handle (schService) must be 
opened or created with the SERVICE_CHANGE_CONFIG access permission:

	SafeServiceHandle schService = NativeMethods.OpenService(schSCManager,
		serviceName, ServiceAccessRights.SERVICE_CHANGE_CONFIG);

Step2. Add the AfterInstall event handler of serviceInstaller1:

	private void serviceInstaller1_AfterInstall(object sender, 
		InstallEventArgs e)
	{
	}

In the event handler, determine if the current operating system supports 
service trigger events (ServiceTriggerStart.IsSupported), and configure the 
service to trigger start if applicable. 
(ServiceTriggerStart.SetServiceTriggerStartOnUSBArrival / 
ServiceTriggerStart.SetServiceTriggerStartOnIPAddressArrival)

	if (ServiceTriggerStart.IsSupported)
	{
		ServiceTriggerStart.SetServiceTriggerStartOnUSBArrival(
			this.serviceInstaller1.ServiceName);
		// [-or-]
		//ServiceTriggerStart.SetServiceTriggerStartOnIPAddressArrival(
		//	this.serviceInstaller1.ServiceName);
	}


/////////////////////////////////////////////////////////////////////////////
References:

MSDN: Service Trigger Events
http://msdn.microsoft.com/en-us/library/dd405513(VS.85).aspx

Windows 7 Training Kit For Developers 
http://www.microsoft.com/downloads/details.aspx?familyid=1C333F06-FADB-4D93-9C80-402621C600E7&displaylang=en

KB: How to create a trigger-start Windows service in Windows 7
http://support.microsoft.com/kb/975425/en-us


/////////////////////////////////////////////////////////////////////////////