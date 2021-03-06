/*********************************** Module Header ***********************************\
* Module Name:  ServiceTriggerStart.cs
* Project:      CSWin7TriggerStartService
* Copyright (c) Microsoft Corporation.
* 
* The file implements functions to set and get the configuration of service trigger 
* start.
* 
* * ServiceTriggerStart.IsSupported 
*   Check whether the current system supports service trigger start. Service trigger 
*   events are not supported until Windows Server 2008 R2 and Windows 7. Wndows Server 
*   2008 R2 and Windows 7 have major version 6 and minor version 1.
*
* * ServiceTriggerStart.IsTriggerStartService
*   Determine whether the specified service is configured to trigger start.
* 
* * ServiceTriggerStart.SetServiceTriggerStartOnUSBArrival
*   Set the service to trigger-start when a generic USB disk becomes available.
* 
* * ServiceTriggerStart.SetServiceTriggerStartOnIPAddressArrival
*   Set the service to trigger-start when the first IP address on the TCP/IP networking 
*   stack becomes available, and trigger-stop when the last IP address on the TCP/IP 
*   networking stack becomes unavailable.
*  
* Services and background processes have tremendous influence on the overall 
* performance of the system. If we could just cut down on the total number of services, 
* we would reduce the total power consumption and increase the overall stability of 
* the system. The Windows 7 Service Control Manager has been extended so that a service 
* can be automatically started and stopped when a specific system event, or trigger, 
* occurs on the system. The new mechanism is called Service Trigger Event. A service 
* can register to be started or stopped when a trigger event occurs. This eliminates 
* the need for services to start when the system starts, or for services to poll or 
* actively wait for an event; a service can start when it is needed, instead of 
* starting automatically whether or not there is work to do. Examples of predefined 
* trigger events include arrival of a device of a specified device interface class or 
* availability of a particular firewall port. A service can also register for a custom 
* trigger event generated by an Event Tracing for Windows (ETW) provider.
* 
* This source is subject to the Microsoft Public License.
* See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
* All other rights reserved.
* 
* THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER 
* EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF 
* MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\*************************************************************************************/

#region Using directives
using System;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;
#endregion


namespace CSWin7TriggerStartService
{
    internal static class ServiceTriggerStart
    {
        #region SupportServiceTriggerStart

        /// <summary>
        /// Check whether the current system supports service trigger start
        /// </summary>
        /// <remarks>
        /// Service trigger events are not supported until Windows Server 2008 R2 
        //  and Windows 7. Wndows Server 2008 R2 and Windows 7 have major version 6 
        //  and minor version 1.
        /// </remarks>
        public static bool IsSupported
        {
            get
            {
                return (Environment.OSVersion.Version >= new Version(6, 1));
            }
        }

        #endregion


        #region GetServiceTriggerInfo

        /// <summary>
        /// Determine whether the specified service is configured to trigger start
        /// </summary>
        /// <param name="serviceName">The name of the service</param>
        /// <returns></returns>
        public static bool IsTriggerStartService(string serviceName)
        {
            // Open the local default service control manager database
            SafeServiceHandle schSCManager = NativeMethods.OpenSCManager(null, null,
                ServiceControlAccessRights.SC_MANAGER_CONNECT);
            if (schSCManager.IsInvalid)
            {
                // If the handle is invalid, get the last Win32 error and throw a 
                // Win32Exception
                throw new Win32Exception();
            }

            try
            {
                // Try to open the service to query its config
                SafeServiceHandle schService = NativeMethods.OpenService(schSCManager,
                    serviceName, ServiceAccessRights.SERVICE_QUERY_CONFIG);
                if (schService.IsInvalid)
                {
                    // If the handle is invalid, get the last Win32 error and throw a 
                    // Win32Exception
                    throw new Win32Exception();
                }

                try
                {
                    return IsTriggerStartService(schService);
                }
                finally
                {
                    schService.Close();
                }
            }
            finally
            {
                schSCManager.Close();
            }
        }


        /// <summary>
        /// Determine whether the specified service is configured to trigger start
        /// </summary>
        /// <param name="hService">
        /// A handle to the service. This handle is returned by the OpenService or 
        /// CreateService function and must have the SERVICE_QUERY_CONFIG access right.
        /// </param>
        /// <returns></returns>
        public static bool IsTriggerStartService(SafeServiceHandle hService)
        {
            // Query the service trigger info size of the current serivce
            int cbBytesNeeded = -1;
            NativeMethods.QueryServiceConfig2(hService,
                ServiceConfig2InfoLevel.SERVICE_CONFIG_TRIGGER_INFO, IntPtr.Zero, 0,
                out cbBytesNeeded);
            if (cbBytesNeeded == -1)
            {
                // If failed, get the last Win32 error and throw a Win32Exception
                throw new Win32Exception();
            }

            // Allocate memory for the service trigger info struct
            IntPtr pBuffer = Marshal.AllocHGlobal(cbBytesNeeded);

            try
            {
                // Retrieve the service trigger info

                if (!NativeMethods.QueryServiceConfig2(hService,
                    ServiceConfig2InfoLevel.SERVICE_CONFIG_TRIGGER_INFO, pBuffer,
                    cbBytesNeeded, out cbBytesNeeded))
                {
                    // If failed, get the last Win32 error and throw a Win32Exception
                    throw new Win32Exception();
                }

                SERVICE_TRIGGER_INFO sti = (SERVICE_TRIGGER_INFO)
                    Marshal.PtrToStructure(pBuffer, typeof(SERVICE_TRIGGER_INFO));

                // You can also retrieve more trigger information of the service

                //for (int i = 0; i < sti.cTriggers; i++)
                //{
                //    // Calculate the address of the SERVICE_TRIGGER struct
                //    IntPtr pst = new IntPtr((long)sti.pTriggers + 
                //        i * Marshal.SizeOf(typeof(SERVICE_TRIGGER)));

                //    // Marshal the native SERVICE_TRIGGER struct to .NET struct
                //    SERVICE_TRIGGER st = (SERVICE_TRIGGER)Marshal.PtrToStructure(pst, 
                //        typeof(SERVICE_TRIGGER));
                //
                //    // Get more information from the SERVICE_TRIGGER struct 
                //    // ...
                //}

                return (sti.cTriggers > 0);
            }
            finally
            {
                // Free the memory of the service trigger info struct
                if (pBuffer != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(pBuffer);
                }
            }
        }

        #endregion


        #region SetServiceTriggerStartOnUSBArrival

        /// <summary>
        /// The GUID_DEVINTERFACE_DISK device interface class is defined for hard disk 
        /// storage devices.
        /// http://msdn.microsoft.com/en-us/library/bb663157.aspx
        /// </summary>
        private static readonly Guid GUID_DEVINTERFACE_DISK =
            new Guid("53F56307-B6BF-11D0-94F2-00A0C91EFB8B");

        /// <summary>
        /// Hardware ID generated by the USB storage port driver.
        /// </summary>
        private const string USBHardwareId = "USBSTOR\\GenDisk";


        /// <summary>
        /// Set the service to trigger-start when a generic USB disk becomes available.
        /// </summary>
        /// <param name="serviceName">The name of the service</param>
        public static void SetServiceTriggerStartOnUSBArrival(string serviceName)
        {
            // Open the local default service control manager database
            SafeServiceHandle schSCManager = NativeMethods.OpenSCManager(null, null,
                ServiceControlAccessRights.SC_MANAGER_CONNECT);
            if (schSCManager.IsInvalid)
            {
                // If the handle is invalid, get the last Win32 error and throw a 
                // Win32Exception
                throw new Win32Exception();
            }

            try
            {
                // Try to open the service with the SERVICE_CHANGE_CONFIG access right
                SafeServiceHandle schService = NativeMethods.OpenService(schSCManager,
                    serviceName, ServiceAccessRights.SERVICE_CHANGE_CONFIG);
                if (schService.IsInvalid)
                {
                    // If the handle is invalid, get the last Win32 error and throw a 
                    // Win32Exception
                    throw new Win32Exception();
                }

                try
                {
                    SetServiceTriggerStartOnUSBArrival(schService);
                }
                finally
                {
                    schService.Close();
                }
            }
            finally
            {
                schSCManager.Close();
            }
        }


        /// <summary>
        /// Set the service to trigger-start when a generic USB disk becomes available.
        /// </summary>
        /// <param name="hService">
        /// A handle to the service. This handle is returned by the OpenService or 
        /// CreateService function and must have the SERVICE_CHANGE_CONFIG access right.
        /// </param>
        public static void SetServiceTriggerStartOnUSBArrival(SafeServiceHandle hService)
        {
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
                    throw new Win32Exception();
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
        }

        #endregion


        #region SetServiceTriggerStartOnIPAddressArrival

        /// <summary>
        /// The event is triggered when the first IP address on the TCP/IP networking stack 
        /// becomes available. 
        /// </summary>
        private static readonly Guid NETWORK_MANAGER_FIRST_IP_ADDRESS_ARRIVAL_GUID =
            new Guid("4F27F2DE-14E2-430B-A549-7CD48CBC8245");

        /// <summary>
        /// The event is triggered when the last IP address on the TCP/IP networking stack 
        /// becomes unavailable.
        /// </summary>
        private static readonly Guid NETWORK_MANAGER_LAST_IP_ADDRESS_REMOVAL_GUID =
            new Guid("CC4BA62A-162E-4648-847A-B6BDF993E335");


        /// <summary>
        /// Set the service to trigger-start when the first IP address on the TCP/IP 
        /// networking stack becomes available, and trigger-stop when the last IP 
        /// address on the TCP/IP networking stack becomes unavailable.
        /// </summary>
        /// <param name="serviceName">The name of the service</param>
        public static void SetServiceTriggerStartOnIPAddressArrival(string serviceName)
        {
            // Open the local default service control manager database
            SafeServiceHandle schSCManager = NativeMethods.OpenSCManager(null, null,
                ServiceControlAccessRights.SC_MANAGER_CONNECT);
            if (schSCManager.IsInvalid)
            {
                // If the handle is invalid, get the last Win32 error and throw a 
                // Win32Exception
                throw new Win32Exception();
            }

            try
            {
                // Try to open the service with the SERVICE_CHANGE_CONFIG access right
                SafeServiceHandle schService = NativeMethods.OpenService(schSCManager,
                    serviceName, ServiceAccessRights.SERVICE_CHANGE_CONFIG);
                if (schService.IsInvalid)
                {
                    // If the handle is invalid, get the last Win32 error and throw a 
                    // Win32Exception
                    throw new Win32Exception();
                }

                try
                {
                    SetServiceTriggerStartOnIPAddressArrival(schService);
                }
                finally
                {
                    schService.Close();
                }
            }
            finally
            {
                schSCManager.Close();
            }
        }


        /// <summary>
        /// Set the service to trigger-start when the first IP address on the TCP/IP 
        /// networking stack becomes available, and trigger-stop when the last IP 
        /// address on the TCP/IP networking stack becomes unavailable.
        /// </summary>
        /// <param name="hService">
        /// A handle to the service. This handle is returned by the OpenService or 
        /// CreateService function and must have the SERVICE_CHANGE_CONFIG access right.
        /// </param>
        public static void SetServiceTriggerStartOnIPAddressArrival(SafeServiceHandle hService)
        {
            IntPtr pGuidIpAddressArrival = IntPtr.Zero;
            IntPtr pGuidIpAddressRemoval = IntPtr.Zero;
            IntPtr pServiceTriggers = IntPtr.Zero;
            IntPtr pServiceTriggerInfo = IntPtr.Zero;

            try
            {
                // Marshal Guid struct NETWORK_MANAGER_FIRST_IP_ADDRESS_ARRIVAL_GUID 
                // and NETWORK_MANAGER_LAST_IP_ADDRESS_REMOVAL_GUID to native memory

                int cbGuid = Marshal.SizeOf(typeof(Guid));
                pGuidIpAddressArrival = Marshal.AllocHGlobal(cbGuid);
                Marshal.StructureToPtr(NETWORK_MANAGER_FIRST_IP_ADDRESS_ARRIVAL_GUID,
                    pGuidIpAddressArrival, false);
                pGuidIpAddressRemoval = Marshal.AllocHGlobal(cbGuid);
                Marshal.StructureToPtr(NETWORK_MANAGER_LAST_IP_ADDRESS_REMOVAL_GUID,
                    pGuidIpAddressRemoval, false);

                // Allocate and set the SERVICE_TRIGGER structure for 
                // NETWORK_MANAGER_FIRST_IP_ADDRESS_ARRIVAL_GUID to start the service

                SERVICE_TRIGGER serviceTrigger1 = new SERVICE_TRIGGER();
                serviceTrigger1.dwTriggerType =
                    ServiceTriggerType.SERVICE_TRIGGER_TYPE_IP_ADDRESS_AVAILABILITY;
                serviceTrigger1.dwAction =
                    ServiceTriggerAction.SERVICE_TRIGGER_ACTION_SERVICE_START;
                serviceTrigger1.pTriggerSubtype = pGuidIpAddressArrival;

                // Allocate and set the SERVICE_TRIGGER structure for 
                // NETWORK_MANAGER_LAST_IP_ADDRESS_REMOVAL_GUID to stop the service

                SERVICE_TRIGGER serviceTrigger2 = new SERVICE_TRIGGER();
                serviceTrigger2.dwTriggerType =
                    ServiceTriggerType.SERVICE_TRIGGER_TYPE_IP_ADDRESS_AVAILABILITY;
                serviceTrigger2.dwAction =
                    ServiceTriggerAction.SERVICE_TRIGGER_ACTION_SERVICE_STOP;
                serviceTrigger2.pTriggerSubtype = pGuidIpAddressRemoval;

                // Marshal the 2 SERVICE_TRIGGER structs to native memory as an array

                int cbServiceTrigger = Marshal.SizeOf(typeof(SERVICE_TRIGGER));
                pServiceTriggers = Marshal.AllocHGlobal(cbServiceTrigger * 2);
                Marshal.StructureToPtr(serviceTrigger1, pServiceTriggers, false);
                Marshal.StructureToPtr(serviceTrigger2,
                    new IntPtr((long)pServiceTriggers + cbServiceTrigger), false);

                // Allocate and set the SERVICE_TRIGGER_INFO structure

                SERVICE_TRIGGER_INFO serviceTriggerInfo = new SERVICE_TRIGGER_INFO();
                serviceTriggerInfo.cTriggers = 2;
                serviceTriggerInfo.pTriggers = pServiceTriggers;

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
                    throw new Win32Exception();
                }
            }
            finally
            {
                // Clean up the native memory

                if (pGuidIpAddressArrival != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(pGuidIpAddressArrival);
                }

                if (pGuidIpAddressRemoval != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(pGuidIpAddressRemoval);
                }

                if (pServiceTriggers != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(pServiceTriggers);
                }

                if (pServiceTriggerInfo != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(pServiceTriggerInfo);
                }
            }
        }

        #endregion
    }
}