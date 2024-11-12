using CommunityToolkit.WinForms.AI.TypedInput;

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
        AITextFormatterComponent.AITextFormatter aiTextFormatter1 = new AITextFormatterComponent.AITextFormatter();
        AIMeasurementFormatterComponent.AIMeasurementFormatter aiMeasurementFormatter1 = new AIMeasurementFormatterComponent.AIMeasurementFormatter();
        Components.AITripFormatterComponent.AITripFormatter aiTripFormatter1 = new Components.AITripFormatterComponent.AITripFormatter();
        AIMeasurementFormatterComponent.AIMeasurementFormatter aiMeasurementFormatter2 = new AIMeasurementFormatterComponent.AIMeasurementFormatter();
        AIDateFormatterComponent.AIDateFormatter aiDateFormatter1 = new AIDateFormatterComponent.AIDateFormatter();
        AITextFormatterComponent.AITextFormatter aiTextFormatter2 = new AITextFormatterComponent.AITextFormatter();
        AIDateFormatterComponent.AIDateFormatter aiDateFormatter2 = new AIDateFormatterComponent.AIDateFormatter();
        _typedInputExtender = new CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel();
        _txtNotes = new TextBox();
        label8 = new Label();
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
        _txtAutomaticTripInfo = new TextBox();
        _aiTextFormatter = new AITextFormatterComponent();
        _aiMeasurementFormatter = new AIMeasurementFormatterComponent();
        _aiTripFormatter = new Components.AITripFormatterComponent();
        _aiDateFormatter = new AIDateFormatterComponent();
        _decimalFormatter = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent();
        _dateFormatter = new CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent();
        label6 = new Label();
        label7 = new Label();
        _typedInputExtender.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_aiTextFormatter).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_aiMeasurementFormatter).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_aiTripFormatter).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_aiDateFormatter).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_decimalFormatter).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_dateFormatter).BeginInit();
        SuspendLayout();
        // 
        // _typedInputExtender
        // 
        _typedInputExtender.BorderStyle = BorderStyle.FixedSingle;
        _typedInputExtender.Controls.Add(_txtNotes);
        _typedInputExtender.Controls.Add(label8);
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
        _typedInputExtender.Controls.Add(_txtAutomaticTripInfo);
        _typedInputExtender.Location = new Point(11, 90);
        _typedInputExtender.Name = "_typedInputExtender";
        _typedInputExtender.Size = new Size(826, 546);
        _typedInputExtender.TabIndex = 2;
        // 
        // _txtNotes
        // 
        _txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _typedInputExtender.SetErrorColor(_txtNotes, null);
        _typedInputExtender.SetErrorText(_txtNotes, "");
        _typedInputExtender.SetFocusColor(_txtNotes, null);
        _typedInputExtender.SetFormatterComponent(_txtNotes, _aiTextFormatter);
        _aiTextFormatter.SetFormatterSettings(_txtNotes, aiTextFormatter1);
        _txtNotes.Location = new Point(222, 504);
        _txtNotes.Name = "_txtNotes";
        _txtNotes.Size = new Size(589, 30);
        _txtNotes.TabIndex = 15;
        _aiTextFormatter.SetValue(_txtNotes, null);
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(30, 507);
        label8.Name = "label8";
        label8.Size = new Size(59, 23);
        label8.TabIndex = 14;
        label8.Text = "Notes:";
        // 
        // _txtGallonsFuelUsed
        // 
        _txtGallonsFuelUsed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _typedInputExtender.SetErrorColor(_txtGallonsFuelUsed, null);
        _typedInputExtender.SetErrorText(_txtGallonsFuelUsed, "");
        _typedInputExtender.SetFocusColor(_txtGallonsFuelUsed, null);
        _typedInputExtender.SetFormatterComponent(_txtGallonsFuelUsed, _aiMeasurementFormatter);
        aiMeasurementFormatter1.TargetUnit = "Gallons";
        _aiMeasurementFormatter.SetFormatterSettings(_txtGallonsFuelUsed, aiMeasurementFormatter1);
        _txtGallonsFuelUsed.Location = new Point(222, 456);
        _txtGallonsFuelUsed.Name = "_txtGallonsFuelUsed";
        _txtGallonsFuelUsed.Size = new Size(589, 30);
        _txtGallonsFuelUsed.TabIndex = 13;
        _aiMeasurementFormatter.SetValue(_txtGallonsFuelUsed, null);
        // 
        // _txtTripStops
        // 
        _txtTripStops.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _typedInputExtender.SetErrorColor(_txtTripStops, null);
        _typedInputExtender.SetErrorText(_txtTripStops, "");
        _typedInputExtender.SetFocusColor(_txtTripStops, null);
        _typedInputExtender.SetFormatterComponent(_txtTripStops, _aiTripFormatter);
        aiTripFormatter1.HomeStateOrCountry = "Washington State";
        aiTripFormatter1.HomeTown = "Duvall";
        _aiTripFormatter.SetFormatterSettings(_txtTripStops, aiTripFormatter1);
        _txtTripStops.Location = new Point(222, 26);
        _txtTripStops.Name = "_txtTripStops";
        _txtTripStops.Size = new Size(589, 30);
        _txtTripStops.TabIndex = 1;
        _aiTripFormatter.SetValue(_txtTripStops, null);
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
        _txtMilesDriven.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _typedInputExtender.SetErrorColor(_txtMilesDriven, null);
        _typedInputExtender.SetErrorText(_txtMilesDriven, "");
        _typedInputExtender.SetFocusColor(_txtMilesDriven, null);
        _typedInputExtender.SetFormatterComponent(_txtMilesDriven, _aiMeasurementFormatter);
        aiMeasurementFormatter2.TargetUnit = "Mile";
        _aiMeasurementFormatter.SetFormatterSettings(_txtMilesDriven, aiMeasurementFormatter2);
        _txtMilesDriven.Location = new Point(222, 407);
        _txtMilesDriven.Name = "_txtMilesDriven";
        _txtMilesDriven.Size = new Size(589, 30);
        _txtMilesDriven.TabIndex = 11;
        _aiMeasurementFormatter.SetValue(_txtMilesDriven, null);
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
        _txtStartDateAndTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _typedInputExtender.SetErrorColor(_txtStartDateAndTime, null);
        _typedInputExtender.SetErrorText(_txtStartDateAndTime, "");
        _typedInputExtender.SetFocusColor(_txtStartDateAndTime, null);
        _typedInputExtender.SetFormatterComponent(_txtStartDateAndTime, _aiDateFormatter);
        aiDateFormatter1.DateTimeFormat = CommunityToolkit.WinForms.TypedInputExtenders.DateTimeFormats.DateTimeCombined;
        _aiDateFormatter.SetFormatterSettings(_txtStartDateAndTime, aiDateFormatter1);
        _txtStartDateAndTime.Location = new Point(222, 309);
        _txtStartDateAndTime.Name = "_txtStartDateAndTime";
        _txtStartDateAndTime.Size = new Size(589, 30);
        _txtStartDateAndTime.TabIndex = 7;
        _aiDateFormatter.SetValue(_txtStartDateAndTime, null);
        // 
        // _txtPurposeOfTrip
        // 
        _txtPurposeOfTrip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _typedInputExtender.SetErrorColor(_txtPurposeOfTrip, null);
        _typedInputExtender.SetErrorText(_txtPurposeOfTrip, "");
        _typedInputExtender.SetFocusColor(_txtPurposeOfTrip, null);
        _typedInputExtender.SetFormatterComponent(_txtPurposeOfTrip, _aiTextFormatter);
        _aiTextFormatter.SetFormatterSettings(_txtPurposeOfTrip, aiTextFormatter2);
        _txtPurposeOfTrip.Location = new Point(222, 178);
        _txtPurposeOfTrip.Multiline = true;
        _txtPurposeOfTrip.Name = "_txtPurposeOfTrip";
        _txtPurposeOfTrip.ScrollBars = ScrollBars.Vertical;
        _txtPurposeOfTrip.Size = new Size(589, 110);
        _txtPurposeOfTrip.TabIndex = 4;
        _aiTextFormatter.SetValue(_txtPurposeOfTrip, null);
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
        label3.Location = new Point(30, 181);
        label3.Name = "label3";
        label3.Size = new Size(127, 23);
        label3.TabIndex = 3;
        label3.Text = "Purpose of trip:";
        // 
        // _txtEndDateAndTime
        // 
        _txtEndDateAndTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _typedInputExtender.SetErrorColor(_txtEndDateAndTime, null);
        _typedInputExtender.SetErrorText(_txtEndDateAndTime, "");
        _typedInputExtender.SetFocusColor(_txtEndDateAndTime, null);
        _typedInputExtender.SetFormatterComponent(_txtEndDateAndTime, _aiDateFormatter);
        aiDateFormatter2.DateTimeFormat = CommunityToolkit.WinForms.TypedInputExtenders.DateTimeFormats.DateTimeCombined;
        _aiDateFormatter.SetFormatterSettings(_txtEndDateAndTime, aiDateFormatter2);
        _txtEndDateAndTime.Location = new Point(222, 358);
        _txtEndDateAndTime.Name = "_txtEndDateAndTime";
        _txtEndDateAndTime.Size = new Size(589, 30);
        _txtEndDateAndTime.TabIndex = 9;
        _aiDateFormatter.SetValue(_txtEndDateAndTime, null);
        // 
        // _txtAutomaticTripInfo
        // 
        _txtAutomaticTripInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        _typedInputExtender.SetErrorColor(_txtAutomaticTripInfo, null);
        _typedInputExtender.SetErrorText(_txtAutomaticTripInfo, "");
        _typedInputExtender.SetFocusColor(_txtAutomaticTripInfo, null);
        _typedInputExtender.SetFormatterComponent(_txtAutomaticTripInfo, null);
        _txtAutomaticTripInfo.Location = new Point(222, 73);
        _txtAutomaticTripInfo.Multiline = true;
        _txtAutomaticTripInfo.Name = "_txtAutomaticTripInfo";
        _txtAutomaticTripInfo.ReadOnly = true;
        _txtAutomaticTripInfo.ScrollBars = ScrollBars.Vertical;
        _txtAutomaticTripInfo.Size = new Size(589, 82);
        _txtAutomaticTripInfo.TabIndex = 2;
        _txtAutomaticTripInfo.TabStop = false;
        // 
        // _aiTripFormatter
        // 
        _aiTripFormatter.ValueChanged += AITripFormatter_ValueChanged;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label6.Location = new Point(3, 10);
        label6.Name = "label6";
        label6.Size = new Size(419, 41);
        label6.TabIndex = 0;
        label6.Text = "Intelligent Async Entry Forms";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label7.Location = new Point(3, 51);
        label7.Name = "label7";
        label7.Size = new Size(319, 28);
        label7.TabIndex = 1;
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
        Size = new Size(858, 654);
        _typedInputExtender.ResumeLayout(false);
        _typedInputExtender.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_aiTextFormatter).EndInit();
        ((System.ComponentModel.ISupportInitialize)_aiMeasurementFormatter).EndInit();
        ((System.ComponentModel.ISupportInitialize)_aiTripFormatter).EndInit();
        ((System.ComponentModel.ISupportInitialize)_aiDateFormatter).EndInit();
        ((System.ComponentModel.ISupportInitialize)_decimalFormatter).EndInit();
        ((System.ComponentModel.ISupportInitialize)_dateFormatter).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel _typedInputExtender;
    private TextBox _txtTripStops;
    private Label _lblTripStops;
    private TextBox _txtStartDateAndTime;
    private Label label1;
    private TextBox _txtEndDateAndTime;
    private Label label2;
    private TextBox _txtAutomaticTripInfo;
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
    private AITextFormatterComponent _aiTextFormatter;
    private TextBox _txtNotes;
    private Label label8;
    private AIMeasurementFormatterComponent _aiMeasurementFormatter;
    private AIDateFormatterComponent _aiDateFormatter;
    private Components.AITripFormatterComponent _aiTripFormatter;
}
