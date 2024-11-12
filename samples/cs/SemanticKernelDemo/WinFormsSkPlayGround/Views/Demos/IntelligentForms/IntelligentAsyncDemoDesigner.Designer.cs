namespace WinFormsSkPlayGround.Views;

partial class IntelligentAsyncDemoDesigner
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
        CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent.DateFormatter dateFormatter1 = new CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent.DateFormatter();
        CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter decimalFormatter1 = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter();
        label1 = new Label();
        _txtInputField1 = new TextBox();
        _txtInputField2 = new TextBox();
        label2 = new Label();
        typedInputExtenderPanel1 = new CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel();
        dateFormatterComponent1 = new CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent();
        decimalFormatterComponent1 = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent();
        typedInputExtenderPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dateFormatterComponent1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)decimalFormatterComponent1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(42, 31);
        label1.Name = "label1";
        label1.Size = new Size(92, 20);
        label1.TabIndex = 0;
        label1.Text = "Input field 1:";
        // 
        // _txtInputField1
        // 
        typedInputExtenderPanel1.SetErrorColor(_txtInputField1, null);
        typedInputExtenderPanel1.SetErrorText(_txtInputField1, "");
        typedInputExtenderPanel1.SetFocusColor(_txtInputField1, null);
        typedInputExtenderPanel1.SetFormatterComponent(_txtInputField1, dateFormatterComponent1);
        dateFormatter1.DateTimeFormat = CommunityToolkit.WinForms.TypedInputExtenders.DateTimeFormats.LongDateSystem;
        dateFormatterComponent1.SetFormatterSettings(_txtInputField1, dateFormatter1);
        _txtInputField1.Location = new Point(166, 28);
        _txtInputField1.Name = "_txtInputField1";
        _txtInputField1.Size = new Size(325, 27);
        _txtInputField1.TabIndex = 1;
        dateFormatterComponent1.SetValue(_txtInputField1, null);
        // 
        // _txtInputField2
        // 
        typedInputExtenderPanel1.SetErrorColor(_txtInputField2, null);
        typedInputExtenderPanel1.SetErrorText(_txtInputField2, "");
        typedInputExtenderPanel1.SetFocusColor(_txtInputField2, null);
        typedInputExtenderPanel1.SetFormatterComponent(_txtInputField2, decimalFormatterComponent1);
        decimalFormatter1.CurrencySymbol = "$";
        decimalFormatter1.DecimalPlaces = 2;
        decimalFormatter1.HasThousandsSeparator = true;
        decimalFormatter1.PlaceCurrencySymbolUpFront = true;
        decimalFormatterComponent1.SetFormatterSettings(_txtInputField2, decimalFormatter1);
        _txtInputField2.Location = new Point(166, 72);
        _txtInputField2.Name = "_txtInputField2";
        _txtInputField2.Size = new Size(325, 27);
        _txtInputField2.TabIndex = 3;
        decimalFormatterComponent1.SetValue(_txtInputField2, null);
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(42, 75);
        label2.Name = "label2";
        label2.Size = new Size(92, 20);
        label2.TabIndex = 2;
        label2.Text = "Input field 2:";
        // 
        // typedInputExtenderPanel1
        // 
        typedInputExtenderPanel1.Controls.Add(_txtInputField1);
        typedInputExtenderPanel1.Controls.Add(label1);
        typedInputExtenderPanel1.Controls.Add(label2);
        typedInputExtenderPanel1.Controls.Add(_txtInputField2);
        typedInputExtenderPanel1.Location = new Point(15, 143);
        typedInputExtenderPanel1.Name = "typedInputExtenderPanel1";
        typedInputExtenderPanel1.Size = new Size(601, 349);
        typedInputExtenderPanel1.TabIndex = 4;
        // 
        // IntelligentAsyncDemoDesigner
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(typedInputExtenderPanel1);
        Name = "IntelligentAsyncDemoDesigner";
        Size = new Size(649, 531);
        typedInputExtenderPanel1.ResumeLayout(false);
        typedInputExtenderPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dateFormatterComponent1).EndInit();
        ((System.ComponentModel.ISupportInitialize)decimalFormatterComponent1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label label1;
    private TextBox _txtInputField1;
    private TextBox _txtInputField2;
    private Label label2;
    private CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel typedInputExtenderPanel1;
    private CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent dateFormatterComponent1;
    private CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent decimalFormatterComponent1;
}
