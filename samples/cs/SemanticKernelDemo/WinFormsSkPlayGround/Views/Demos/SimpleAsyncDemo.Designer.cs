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
        _spinner = new CommunityToolkit.WinForms.TypedInputExtenders.SpinnerControl();
        SuspendLayout();
        // 
        // _spinner
        // 
        _spinner.Dock = DockStyle.Fill;
        _spinner.Font = new Font("Segoe UI", 128F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _spinner.IsSpinning = false;
        _spinner.Location = new Point(0, 0);
        _spinner.Margin = new Padding(4, 0, 4, 0);
        _spinner.Name = "_spinner";
        _spinner.Size = new Size(1059, 591);
        _spinner.TabIndex = 1;
        _spinner.Text = " X";
        _spinner.TextAlign = ContentAlignment.MiddleCenter;
        _spinner.Click += Spinner_ClickHandler;
        _spinner.DoubleClick += Spinner_DoubleClick;
        // 
        // SimpleAsyncDemo
        // 
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(_spinner);
        Margin = new Padding(4, 4, 4, 4);
        Name = "SimpleAsyncDemo";
        Size = new Size(1059, 591);
        ResumeLayout(false);
    }

    #endregion

    private CommunityToolkit.WinForms.TypedInputExtenders.SpinnerControl _spinner;
}
