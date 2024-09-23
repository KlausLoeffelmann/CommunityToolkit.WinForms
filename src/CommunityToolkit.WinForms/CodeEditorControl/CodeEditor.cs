using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Windows.Win32.Foundation;

using static Windows.Win32.PInvoke;

namespace CommunityToolkit.WinForms.Controls;

public partial class CodeEditorControl : RichTextBox
{
    public event HandledEventHandler? PasteClipboard;

    private const string PasteString = "Paste";
    private const uint WM_REFLECT = WM_USER + 0x1C00;

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);

        // Get the current event mask
        var eventMask = SendMessage((HWND)Handle, EM_GETEVENTMASK, 0, 0);

        // Set the event mask to include ENM_CLIPFORMAT
        SendMessage((HWND)Handle, EM_SETEVENTMASK, 0, (LPARAM)(eventMask.Value | ENM_CLIPFORMAT));
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData == (Keys.Control | Keys.V) || keyData == (Keys.Shift | Keys.Insert))
        {
            // Perform the paste operation
            OnPasteClipboard(new HandledEventArgs());
            // Let the existing extended paste code run
            // Return true to indicate the key has been handled
            return true;
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }

    protected virtual void OnPasteClipboard(HandledEventArgs e)
    {
        PasteClipboard?.Invoke(this, e);
        if (e.Handled)
        {
            return;
        }

        SuspendUpdates();
        ApplyDesiredFont();
        ResumeUpdates();
    }

    /// <summary>
    ///  Suspends the painting of a control.
    /// </summary>
    /// <param name="control">The control to suspend.</param>
    public void SuspendUpdates()
    {
        SendMessage((HWND)Handle, WM_SETREDRAW, 0, 0);
    }

    /// <summary>
    ///  Resumes the painting of a control.
    /// </summary>
    /// <param name="control">The control to resume.</param>
    public void ResumeUpdates()
    {
        SendMessage((HWND)Handle, WM_SETREDRAW, 1, IntPtr.Zero);
        Invalidate(true);
    }

    // Apply the desired font to the selected text
    private void ApplyDesiredFont()
    {
        Font desiredFont = new("Cascadia Code", 14f);

        SelectAll();
        SelectionFont = desiredFont;

        // Iterate word by word through the selection and set every 3rd word to a different color:
        var words = Text.Split([' ', '\r', '\n'], StringSplitOptions.RemoveEmptyEntries);
        for (var i = 0; i < words.Length; i += 3)
        {
            var word = words[i];
            var startIndex = Text.IndexOf(word, StringComparison.Ordinal);
            var length = word.Length;
            Select(startIndex, length);
            SelectionColor = Color.Red;
        }

        // Clear the selection, scroll to the end, and set the cursor to the beginning:
        SelectionStart = TextLength-1;
        SelectionLength = 0;
        ScrollToCaret();
    }

    protected override void WndProc(ref Message m)
    {
        if (!IsAncestorSiteInDesignMode)
            Debug.Write($"[{DateTime.Now:HH:mm:ss-fff}]{m}");

        if (m.Msg == WM_REFLECT + WM_NOTIFY)
        {
            NMHDR hdr = Marshal.PtrToStructure<NMHDR>(m.LParam);

            if (!IsAncestorSiteInDesignMode)
                Debug.WriteLine($" code={hdr.code}");

            if (hdr.code == EN_CLIPFORMAT)
            {
                OnPasteClipboard(new HandledEventArgs());
                return;
            }
        }

        if (!IsAncestorSiteInDesignMode)
            Debug.WriteLine(string.Empty);

        base.WndProc(ref m);
    }
}
