using CommunityToolkit.WinForms.FluentUI;

namespace WinFormsSkPlayGround.Views;

partial class SimpleAsyncDemo
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        _mainLayoutPanel = new TableLayoutPanel();
        _txtNonBlockingTextBox = new TextBox();
        _spinner = new SpinnerControl();
        _txtBlockingTextBoxFocus = new TextBox();
        _mainLayoutPanel.SuspendLayout();
        SuspendLayout();
        // 
        // _mainLayoutPanel
        // 
        _mainLayoutPanel.ColumnCount = 2;
        _mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        _mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        _mainLayoutPanel.Controls.Add(_txtNonBlockingTextBox, 1, 1);
        _mainLayoutPanel.Controls.Add(_spinner, 0, 0);
        _mainLayoutPanel.Controls.Add(_txtBlockingTextBoxFocus, 0, 1);
        _mainLayoutPanel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _mainLayoutPanel.Location = new Point(0, 0);
        _mainLayoutPanel.Name = "_mainLayoutPanel";
        _mainLayoutPanel.RowCount = 2;
        _mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        _mainLayoutPanel.RowStyles.Add(new RowStyle());
        _mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        _mainLayoutPanel.Size = new Size(741, 570);
        _mainLayoutPanel.TabIndex = 0;
        // 
        // _txtNonBlockingTextBox
        // 
        _txtNonBlockingTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        _txtNonBlockingTextBox.Location = new Point(427, 519);
        _txtNonBlockingTextBox.Margin = new Padding(20);
        _txtNonBlockingTextBox.Name = "_txtNonBlockingTextBox";
        _txtNonBlockingTextBox.PlaceholderText = "Normal TextBox";
        _txtNonBlockingTextBox.Size = new Size(256, 31);
        _txtNonBlockingTextBox.TabIndex = 4;
        _txtNonBlockingTextBox.LostFocus += NonBlockingTextBox_LostFocus;
        // 
        // _spinner
        // 
        _spinner.Anchor = AnchorStyles.None;
        _spinner.AutoSize = true;
        _mainLayoutPanel.SetColumnSpan(_spinner, 2);
        _spinner.Font = new Font("Segoe Boot Semilight", 156F);
        _spinner.ForeColor = SystemColors.ControlText;
        _spinner.IsSpinning = false;
        _spinner.Location = new Point(125, 76);
        _spinner.Name = "_spinner";
        _spinner.Size = new Size(490, 346);
        _spinner.TabIndex = 2;
        _spinner.TextAlign = ContentAlignment.MiddleCenter;
        _spinner.Click += Spinner_ClickHandler;
        _spinner.DoubleClick += Spinner_DoubleClick;
        // 
        // _txtBlockingTextBoxFocus
        // 
        _txtBlockingTextBoxFocus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        _txtBlockingTextBoxFocus.Location = new Point(57, 519);
        _txtBlockingTextBoxFocus.Margin = new Padding(20);
        _txtBlockingTextBoxFocus.Name = "_txtBlockingTextBoxFocus";
        _txtBlockingTextBoxFocus.PlaceholderText = "Blocking TextBox";
        _txtBlockingTextBoxFocus.Size = new Size(256, 31);
        _txtBlockingTextBoxFocus.TabIndex = 3;
        _txtBlockingTextBoxFocus.LostFocus += BlockingTextBox_LostFocus;
        // 
        // SimpleAsyncDemo
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(_mainLayoutPanel);
        Name = "SimpleAsyncDemo";
        Size = new Size(741, 570);
        _mainLayoutPanel.ResumeLayout(false);
        _mainLayoutPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel _mainLayoutPanel;
    private SpinnerControl _spinner;
    private TextBox _txtBlockingTextBoxFocus;
    private TextBox _txtNonBlockingTextBox;
}
