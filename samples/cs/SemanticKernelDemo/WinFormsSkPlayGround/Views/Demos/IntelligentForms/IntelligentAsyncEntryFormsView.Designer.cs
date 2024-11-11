using WinFormsSkPlayGround.Components;

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
        _typedInputExtender = new CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel();
        _txtGallonsFuelUsed = new TextBox();
        _txtTripStops = new TextBox();
        label5 = new Label();
        _lblTripStops = new Label();
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
        _decimalFormatter = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent();
        _aiTextFormatter = new AITextFormatterComponent();
        _dateFormatter = new CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent();
        label6 = new Label();
        label7 = new Label();
        _typedInputExtender.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_decimalFormatter).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_aiTextFormatter).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_dateFormatter).BeginInit();
        SuspendLayout();
        // 
        // _typedInputExtender
        // 
        _typedInputExtender.BorderStyle = BorderStyle.FixedSingle;
        _typedInputExtender.Controls.Add(_txtGallonsFuelUsed);
        _typedInputExtender.Controls.Add(_txtTripStops);
        _typedInputExtender.Controls.Add(label5);
        _typedInputExtender.Controls.Add(_lblTripStops);
        _typedInputExtender.Controls.Add(_txtMilesDriven);
        _typedInputExtender.Controls.Add(label1);
        _typedInputExtender.Controls.Add(label4);
        _typedInputExtender.Controls.Add(_txtStartDateAndTime);
        _typedInputExtender.Controls.Add(_txtPurposeOfTrip);
        _typedInputExtender.Controls.Add(label2);
        _typedInputExtender.Controls.Add(label3);
        _typedInputExtender.Controls.Add(_txtEndDateAndTime);
        _typedInputExtender.Controls.Add(_chkBusiness);
        _typedInputExtender.Controls.Add(_txtAutomaticTripInfo);
        _typedInputExtender.Location = new Point(11, 90);
        _typedInputExtender.Name = "_typedInputExtender";
        _typedInputExtender.Size = new Size(865, 526);
        _typedInputExtender.TabIndex = 14;
        // 
        // _txtGallonsFuelUsed
        // 
        _typedInputExtender.SetErrorColor(_txtGallonsFuelUsed, null);
        _typedInputExtender.SetErrorText(_txtGallonsFuelUsed, "");
        _typedInputExtender.SetFocusColor(_txtGallonsFuelUsed, null);
        _typedInputExtender.SetFormatterComponent(_txtGallonsFuelUsed, _decimalFormatter);
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
        _typedInputExtender.SetErrorColor(_txtTripStops, null);
        _typedInputExtender.SetErrorText(_txtTripStops, "");
        _typedInputExtender.SetFocusColor(_txtTripStops, null);
        _typedInputExtender.SetFormatterComponent(_txtTripStops, _aiTextFormatter);
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
        // _lblTripStops
        // 
        _lblTripStops.AutoSize = true;
        _lblTripStops.Location = new Point(30, 29);
        _lblTripStops.Name = "_lblTripStops";
        _lblTripStops.Size = new Size(87, 23);
        _lblTripStops.TabIndex = 0;
        _lblTripStops.Text = "Trip stops:";
        // 
        // _txtMilesDriven
        // 
        _typedInputExtender.SetErrorColor(_txtMilesDriven, null);
        _typedInputExtender.SetErrorText(_txtMilesDriven, "");
        _typedInputExtender.SetFocusColor(_txtMilesDriven, null);
        _typedInputExtender.SetFormatterComponent(_txtMilesDriven, _decimalFormatter);
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
        _typedInputExtender.SetErrorColor(_txtStartDateAndTime, null);
        _typedInputExtender.SetErrorText(_txtStartDateAndTime, "");
        _typedInputExtender.SetFocusColor(_txtStartDateAndTime, null);
        _typedInputExtender.SetFormatterComponent(_txtStartDateAndTime, _dateFormatter);
        _dateFormatter.SetFormatterSettings(_txtStartDateAndTime, dateFormatter1);
        _txtStartDateAndTime.Location = new Point(222, 309);
        _txtStartDateAndTime.Name = "_txtStartDateAndTime";
        _txtStartDateAndTime.Size = new Size(589, 30);
        _txtStartDateAndTime.TabIndex = 7;
        _dateFormatter.SetValue(_txtStartDateAndTime, new DateTime(0L));
        // 
        // _txtPurposeOfTrip
        // 
        _typedInputExtender.SetErrorColor(_txtPurposeOfTrip, null);
        _typedInputExtender.SetErrorText(_txtPurposeOfTrip, "");
        _typedInputExtender.SetFocusColor(_txtPurposeOfTrip, null);
        _typedInputExtender.SetFormatterComponent(_txtPurposeOfTrip, null);
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
        _typedInputExtender.SetErrorColor(_txtEndDateAndTime, null);
        _typedInputExtender.SetErrorText(_txtEndDateAndTime, "");
        _typedInputExtender.SetFocusColor(_txtEndDateAndTime, null);
        _typedInputExtender.SetFormatterComponent(_txtEndDateAndTime, _dateFormatter);
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
        _typedInputExtender.SetErrorColor(_txtAutomaticTripInfo, null);
        _typedInputExtender.SetErrorText(_txtAutomaticTripInfo, "");
        _typedInputExtender.SetFocusColor(_txtAutomaticTripInfo, null);
        _typedInputExtender.SetFormatterComponent(_txtAutomaticTripInfo, null);
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
        label6.Location = new Point(3, 10);
        label6.Name = "label6";
        label6.Size = new Size(419, 41);
        label6.TabIndex = 15;
        label6.Text = "Intelligent Async Entry Forms";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label7.Location = new Point(3, 51);
        label7.Name = "label7";
        label7.Size = new Size(319, 28);
        label7.TabIndex = 16;
        label7.Text = "(Stilted driver's logbook example)";
        // 
        // IntelligentAsyncEntryFormsView
        // 
        AutoScaleDimensions = new SizeF(9F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(_typedInputExtender);
        Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Name = "IntelligentAsyncEntryFormsView";
        Size = new Size(892, 638);
        _typedInputExtender.ResumeLayout(false);
        _typedInputExtender.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_decimalFormatter).EndInit();
        ((System.ComponentModel.ISupportInitialize)_aiTextFormatter).EndInit();
        ((System.ComponentModel.ISupportInitialize)_dateFormatter).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel _typedInputExtender;
    private TextBox _txtTripStops;
    private AITextFormatterComponent.AITextFormatter _aiTextFormatter1;
    private Label _lblTripStops;
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
    private CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent _dateFormatter;
    private Label label6;
    private Label label7;
    private Components.AITextFormatterComponent _aiTextFormatter;
}
