using System.Runtime.InteropServices;

namespace CommunityToolkit.WinForms.Controls;

public partial class CodeEditorControl
{
    [StructLayout(LayoutKind.Sequential)]
    private struct ENCLIPFORMAT
    {
        public NMHDR nmhdr;
        public int cfFormat; // Clipboard format
        public int fCopy;    // TRUE for copy, FALSE for paste
        public IntPtr hRes;  // Handle to resource
        public IntPtr hMetaPict; // Handle to Metafile Picture
    }
}
