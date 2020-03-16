﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;

internal static class NativeWinAPI
{
   internal static readonly int GWL_EXSTYLE = -20;
   internal static readonly int WS_EX_COMPOSITE = 0x02000000;

   [DllImport("user32")]
   internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

    [DllImport("user32")]
   internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
}