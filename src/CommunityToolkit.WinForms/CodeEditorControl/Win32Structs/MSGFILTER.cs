namespace CommunityToolkit.WinForms.Controls;

using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal struct MSGFILTER
{
    public NMHDR nmhdr;
    public int msg;
    public IntPtr wParam;
    public IntPtr lParam;
}
