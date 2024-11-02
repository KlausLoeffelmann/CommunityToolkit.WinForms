namespace CommunityToolkit.WinForms.Controls;

using System;
using System.Runtime.InteropServices;

// Structures
[StructLayout(LayoutKind.Sequential)]
internal struct NMHDR
{
    public IntPtr hwndFrom;
    public IntPtr idFrom;
    public int code;
}
