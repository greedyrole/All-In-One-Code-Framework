/****************************** Module Header ******************************\
 * Module Name:  MINIDUMP_EXCEPTION_INFORMATION.cs
 * Project:      CSCreateMiniDump
 * Copyright (c) Microsoft Corporation.
 * 
 * Contains the exception information written to the minidump file by the 
 * MiniDumpWriteDump function
 * 
 * This source is subject to the Microsoft Public License.
 * See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
 * All other rights reserved.
 * 
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
 * EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
 * WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

using System;
using System.Runtime.InteropServices;

namespace CSCreateMiniDump.MiniDump
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct MINIDUMP_EXCEPTION_INFORMATION
    {
        /// <summary>
        /// The identifier of the thread throwing the exception.
        /// </summary>
        public int ThreadId;

        /// <summary>
        /// A pointer to an EXCEPTION_POINTERS structure specifying a computer-independent
        /// description of the exception and the processor context at the time of the 
        /// exception.
        /// </summary>
        public IntPtr ExceptionPointers;

        /// <summary>
        /// Determines where to get the memory regions pointed to by the ExceptionPointers member. 
        /// Set to TRUE if the memory resides in the process being debugged (the target process 
        /// of the debugger). 
        /// Otherwise, set to FALSE if the memory resides in the address space of the calling 
        /// program (the debugger process). If you are accessing local memory (in the calling
        /// process) you should not set this member to TRUE.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool ClientPointers;
    }

}
