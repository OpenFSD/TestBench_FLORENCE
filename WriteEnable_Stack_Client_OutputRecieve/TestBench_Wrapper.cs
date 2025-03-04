/*
 *  Managed C# wrapper for FLORENCE Server library by Jasper Assembly Pty Ltd.
 *  Copyright (c) 2022 - 2025 Brenton James Maddocks BEng(CompSys).  
 *  All rights reserved.
 */
using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace TestBench.Server_IO
{
    public static class Library
    {
        [DllImport("WriteEnable_Stack_Client_OutputRecieve.dll", CharSet = CharSet.Unicode)]
        public static extern void Create_WriteEnable_Stack_Client_OutputRecieve();
    }
}
