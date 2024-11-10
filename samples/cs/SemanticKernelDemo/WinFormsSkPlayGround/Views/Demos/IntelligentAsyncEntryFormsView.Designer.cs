namespace WinFormsSkPlayGround.Views;

partial class IntelligentAsyncEntryFormsView
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
        CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter decimalFormatter1 = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter();
        CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter decimalFormatter2 = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter();
        CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent.DateFormatter dateFormatter1 = new CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent.DateFormatter();
        CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent.DateFormatter dateFormatter2 = new CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent.DateFormatter();
        typedInputExtenderPanel1 = new CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel();
        _txtGallonsFuelUsed = new TextBox();
        _txtTripStops = new TextBox();
        label5 = new Label();
        _lblNewTodoItem = new Label();
        _txtMilesDriven = new TextBox();
        label1 = new Label();
        label4 = new Label();
        _txtStartDateAndTime = new TextBox();
        _txtPurposeOfTrip = new TextBox();
        label2 = new Label();
        label3 = new Label();
        _txtEndDateAndTime = new TextBox();
        _chkBusiness = new CheckBox();
        _txtAutomaticTripInfo = new TextBox();
        _dateFormatter = new CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent();
        _decimalFormatter = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent();
        label6 = new Label();
        typedInputExtenderPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_dateFormatter).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_decimalFormatter).BeginInit();
        SuspendLayout();
        // 
        // typedInputExtenderPanel1
        // 
        typedInputExtenderPanel1.BorderStyle = BorderStyle.FixedSingle;
        typedInputExtenderPanel1.Controls.Add(_txtGallonsFuelUsed);
        typedInputExtenderPanel1.Controls.Add(_txtTripStops);
        typedInputExtenderPanel1.Controls.Add(label5);
        typedInputExtenderPanel1.Controls.Add(_lblNewTodoItem);
        typedInputExtenderPanel1.Controls.Add(_txtMilesDriven);
        typedInputExtenderPanel1.Controls.Add(label1);
        typedInputExtenderPanel1.Controls.Add(label4);
        typedInputExtenderPanel1.Controls.Add(_txtStartDateAndTime);
        typedInputExtenderPanel1.Controls.Add(_txtPurposeOfTrip);
        typedInputExtenderPanel1.Controls.Add(label2);
        typedInputExtenderPanel1.Controls.Add(label3);
        typedInputExtenderPanel1.Controls.Add(_txtEndDateAndTime);
        typedInputExtenderPanel1.Controls.Add(_chkBusiness);
        typedInputExtenderPanel1.Controls.Add(_txtAutomaticTripInfo);
        typedInputExtenderPanel1.Location = new Point(17, 96);
        typedInputExtenderPanel1.Name = "typedInputExtenderPanel1";
        typedInputExtenderPanel1.Size = new Size(865, 526);
        typedInputExtenderPanel1.TabIndex = 14;
        // 
        // _txtGallonsFuelUsed
        // 
        typedInputExtenderPanel1.SetErrorColor(_txtGallonsFuelUsed, null);
        typedInputExtenderPanel1.SetErrorText(_txtGallonsFuelUsed, "");
        typedInputExtenderPanel1.SetFocusColor(_txtGallonsFuelUsed, null);
        typedInputExtenderPanel1.SetFormatterComponent(_txtGallonsFuelUsed, _decimalFormatter);
        decimalFormatter1.CurrencySymbol = null;
        decimalFormatter1.DecimalPlaces = 0;
        _decimalFormatter.SetFormatterSettings(_txtGallonsFuelUsed, decimalFormatter1);
        _txtGallonsFuelUsed.Location = new Point(222, 456);
        _txtGallonsFuelUsed.Name = "_txtGallonsFuelUsed";
        _txtGallonsFuelUsed.Size = new Size(589, 30);
        _txtGallonsFuelUsed.TabIndex = 13;
        _decimalFormatter.SetValue(_txtGallonsFuelUsed, null);
        // 
        // _txtTripStops
        // 
        typedInputExtenderPanel1.SetErrorColor(_txtTripStops, null);
        typedInputExtenderPanel1.SetErrorText(_txtTripStops, "");
        typedInputExtenderPanel1.SetFocusColor(_txtTripStops, null);
        typedInputExtenderPanel1.SetFormatterComponent(_txtTripStops, null);
        _txtTripStops.Location = new Point(222, 26);
        _txtTripStops.Name = "_txtTripStops";
        _txtTripStops.Size = new Size(589, 30);
        _txtTripStops.TabIndex = 1;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(30, 459);
        label5.Name = "label5";
        label5.Size = new Size(144, 23);
        label5.TabIndex = 12;
        label5.Text = "Gallons fuel used:";
        // 
        // _lblNewTodoItem
        // 
        _lblNewTodoItem.AutoSize = true;
        _lblNewTodoItem.Location = new Point(30, 29);
        _lblNewTodoItem.Name = "_lblNewTodoItem";
        _lblNewTodoItem.Size = new Size(87, 23);
        _lblNewTodoItem.TabIndex = 0;
        _lblNewTodoItem.Text = "Trip stops:";
        // 
        // _txtMilesDriven
        // 
        typedInputExtenderPanel1.SetErrorColor(_txtMilesDriven, null);
        typedInputExtenderPanel1.SetErrorText(_txtMilesDriven, "");
        typedInputExtenderPanel1.SetFocusColor(_txtMilesDriven, null);
        typedInputExtenderPanel1.SetFormatterComponent(_txtMilesDriven, _decimalFormatter);
        decimalFormatter2.CurrencySymbol = null;
        decimalFormatter2.DecimalPlaces = 0;
        _decimalFormatter.SetFormatterSettings(_txtMilesDriven, decimalFormatter2);
        _txtMilesDriven.Location = new Point(222, 407);
        _txtMilesDriven.Name = "_txtMilesDriven";
        _txtMilesDriven.Size = new Size(589, 30);
        _txtMilesDriven.TabIndex = 11;
        _decimalFormatter.SetValue(_txtMilesDriven, null);
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(30, 312);
        label1.Name = "label1";
        label1.Size = new Size(163, 23);
        label1.TabIndex = 6;
        label1.Text = "Start Date and time:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(30, 410);
        label4.Name = "label4";
        label4.Size = new Size(101, 23);
        label4.TabIndex = 10;
        label4.Text = "Miles driven";
        // 
        // _txtStartDateAndTime
        // 
        typedInputExtenderPanel1.SetErrorColor(_txtStartDateAndTime, null);
        typedInputExtenderPanel1.SetErrorText(_txtStartDateAndTime, "");
        typedInputExtenderPanel1.SetFocusColor(_txtStartDateAndTime, null);
        typedInputExtenderPanel1.SetFormatterComponent(_txtStartDateAndTime, _dateFormatter);
        _dateFormatter.SetFormatterSettings(_txtStartDateAndTime, dateFormatter1);
        _txtStartDateAndTime.Location = new Point(222, 309);
        _txtStartDateAndTime.Name = "_txtStartDateAndTime";
        _txtStartDateAndTime.Size = new Size(589, 30);
        _txtStartDateAndTime.TabIndex = 7;
        _dateFormatter.SetValue(_txtStartDateAndTime, new DateTime(0L));
        // 
        // _txtPurposeOfTrip
        // 
        typedInputExtenderPanel1.SetErrorColor(_txtPurposeOfTrip, null);
        typedInputExtenderPanel1.SetErrorText(_txtPurposeOfTrip, "");
        typedInputExtenderPanel1.SetFocusColor(_txtPurposeOfTrip, null);
        typedInputExtenderPanel1.SetFormatterComponent(_txtPurposeOfTrip, null);
        _txtPurposeOfTrip.Location = new Point(222, 143);
        _txtPurposeOfTrip.Multiline = true;
        _txtPurposeOfTrip.Name = "_txtPurposeOfTrip";
        _txtPurposeOfTrip.Size = new Size(589, 82);
        _txtPurposeOfTrip.TabIndex = 4;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(30, 361);
        label2.Name = "label2";
        label2.Size = new Size(157, 23);
        label2.TabIndex = 8;
        label2.Text = "End Date and time:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(30, 146);
        label3.Name = "label3";
        label3.Size = new Size(127, 23);
        label3.TabIndex = 3;
        label3.Text = "Purpose of trip:";
        // 
        // _txtEndDateAndTime
        // 
        typedInputExtenderPanel1.SetErrorColor(_txtEndDateAndTime, null);
        typedInputExtenderPanel1.SetErrorText(_txtEndDateAndTime, "");
        typedInputExtenderPanel1.SetFocusColor(_txtEndDateAndTime, null);
        typedInputExtenderPanel1.SetFormatterComponent(_txtEndDateAndTime, _dateFormatter);
        _dateFormatter.SetFormatterSettings(_txtEndDateAndTime, dateFormatter2);
        _txtEndDateAndTime.Location = new Point(222, 358);
        _txtEndDateAndTime.Name = "_txtEndDateAndTime";
        _txtEndDateAndTime.Size = new Size(589, 30);
        _txtEndDateAndTime.TabIndex = 9;
        _dateFormatter.SetValue(_txtEndDateAndTime, new DateTime(0L));
        // 
        // _chkBusiness
        // 
        _chkBusiness.AutoSize = true;
        _chkBusiness.Location = new Point(236, 253);
        _chkBusiness.Name = "_chkBusiness";
        _chkBusiness.Size = new Size(155, 27);
        _chkBusiness.TabIndex = 5;
        _chkBusiness.Text = "was Businesstrip";
        _chkBusiness.UseVisualStyleBackColor = true;
        // 
        // _txtAutomaticTripInfo
        // 
        typedInputExtenderPanel1.SetErrorColor(_txtAutomaticTripInfo, null);
        typedInputExtenderPanel1.SetErrorText(_txtAutomaticTripInfo, "");
        typedInputExtenderPanel1.SetFocusColor(_txtAutomaticTripInfo, null);
        typedInputExtenderPanel1.SetFormatterComponent(_txtAutomaticTripInfo, null);
        _txtAutomaticTripInfo.Location = new Point(222, 73);
        _txtAutomaticTripInfo.Multiline = true;
        _txtAutomaticTripInfo.Name = "_txtAutomaticTripInfo";
        _txtAutomaticTripInfo.ReadOnly = true;
        _txtAutomaticTripInfo.Size = new Size(589, 55);
        _txtAutomaticTripInfo.TabIndex = 2;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label6.Location = new Point(17, 22);
        label6.Name = "label6";
        label6.Size = new Size(419, 41);
        label6.TabIndex = 15;
        label6.Text = "Intelligent Async Entry Forms";
        // 
        // IntelligentAsyncEntryFormsView
        // 
        AutoScaleDimensions = new SizeF(9F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(label6);
        Controls.Add(typedInputExtenderPanel1);
        Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Name = "IntelligentAsyncEntryFormsView";
        Size = new Size(1024, 648);
        typedInputExtenderPanel1.ResumeLayout(false);
        typedInputExtenderPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_dateFormatter).EndInit();
        ((System.ComponentModel.ISupportInitialize)_decimalFormatter).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel typedInputExtenderPanel1;
    private TextBox _txtTripStops;
    private CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent _dateFormatter;
    private Label _lblNewTodoItem;
    private TextBox _txtStartDateAndTime;
    private Label label1;
    private TextBox _txtEndDateAndTime;
    private Label label2;
    private TextBox _txtAutomaticTripInfo;
    private CheckBox _chkBusiness;
    private TextBox _txtPurposeOfTrip;
    private Label label3;
    private TextBox _txtMilesDriven;
    private Label label4;
    private TextBox _txtGallonsFuelUsed;
    private Label label5;
    private CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent _decimalFormatter;
    private Label label6;
}
