namespace CommunityToolkit.WinForms.EntryFormatter;

public partial class DataEntryPanel
{
    private class DataEntryExtenderProperties(IDataEntryFormatterComponent? formatterComponent, Color? focusColor, Color? errorColor)
    {
        public Color? FocusColor { get; set; } = focusColor;
        public FocusSelectionBehavior FocusSelectionBehavior { get; set; } = FocusSelectionBehavior.SelectAll;
        public Color? ErrorColor { get; set; } = errorColor;
        public string? ErrorText { get; set; } = string.Empty;
        public IDataEntryFormatterComponent? FormatterComponent { get; set; } = formatterComponent;
        public bool HasFocus { get; internal set; }
        public string? EditedValue { get; internal set; }
        public bool HasError { get; internal set; }
        public Color OriginalBackColor { get; internal set; }
        public bool ChangingValueInternally { get; internal set; }
        public object? ValueInternal { get; internal set; }
        public bool CommitOnFocusedRead { get; internal set; }
        public string DebugName { get; internal set; }
    }
}
