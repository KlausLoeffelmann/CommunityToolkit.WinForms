namespace WinFormsSkPlayGround.Views.Demos
{
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
            CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent.DateFormatter dateFormatter1 = new CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent.DateFormatter();
            typedInputExtenderPanel1 = new CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel();
            _txtTripStops = new TextBox();
            _dateFormatter = new CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent();
            _lblNewTodoItem = new Label();
            _txtStartDateAndTime = new TextBox();
            label1 = new Label();
            _txtEndDateAndTime = new TextBox();
            label2 = new Label();
            _txtAutomaticTripInfo = new TextBox();
            _chkBusiness = new CheckBox();
            _txtPurposeOfTrip = new TextBox();
            label3 = new Label();
            _txtMilesDriven = new TextBox();
            label4 = new Label();
            _txtGallonsFuelUsed = new TextBox();
            label5 = new Label();
            _decimalFormatter = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent();
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
            typedInputExtenderPanel1.Location = new Point(17, 26);
            typedInputExtenderPanel1.Name = "typedInputExtenderPanel1";
            typedInputExtenderPanel1.Size = new Size(865, 526);
            typedInputExtenderPanel1.TabIndex = 14;
            // 
            // _txtTripStops
            // 
            typedInputExtenderPanel1.SetErrorColor(_txtTripStops, null);
            typedInputExtenderPanel1.SetErrorText(_txtTripStops, "");
            typedInputExtenderPanel1.SetFocusColor(_txtTripStops, null);
            typedInputExtenderPanel1.SetFormatterComponent(_txtTripStops, _dateFormatter);
            _dateFormatter.SetFormatterSettings(_txtTripStops, dateFormatter1);
            _txtTripStops.Location = new Point(222, 26);
            _txtTripStops.Name = "_txtTripStops";
            _txtTripStops.Size = new Size(589, 30);
            _txtTripStops.TabIndex = 1;
            _dateFormatter.SetValue(_txtTripStops, new DateTime(0L));
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
            // _txtStartDateAndTime
            // 
            typedInputExtenderPanel1.SetErrorColor(_txtStartDateAndTime, null);
            typedInputExtenderPanel1.SetErrorText(_txtStartDateAndTime, "");
            typedInputExtenderPanel1.SetFocusColor(_txtStartDateAndTime, null);
            typedInputExtenderPanel1.SetFormatterComponent(_txtStartDateAndTime, null);
            _txtStartDateAndTime.Location = new Point(222, 309);
            _txtStartDateAndTime.Name = "_txtStartDateAndTime";
            _txtStartDateAndTime.Size = new Size(589, 30);
            _txtStartDateAndTime.TabIndex = 7;
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
            // _txtEndDateAndTime
            // 
            typedInputExtenderPanel1.SetErrorColor(_txtEndDateAndTime, null);
            typedInputExtenderPanel1.SetErrorText(_txtEndDateAndTime, "");
            typedInputExtenderPanel1.SetFocusColor(_txtEndDateAndTime, null);
            typedInputExtenderPanel1.SetFormatterComponent(_txtEndDateAndTime, null);
            _txtEndDateAndTime.Location = new Point(222, 359);
            _txtEndDateAndTime.Name = "_txtEndDateAndTime";
            _txtEndDateAndTime.Size = new Size(589, 30);
            _txtEndDateAndTime.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 362);
            label2.Name = "label2";
            label2.Size = new Size(157, 23);
            label2.TabIndex = 8;
            label2.Text = "End Date and time:";
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
            // _chkBusiness
            // 
            _chkBusiness.AutoSize = true;
            _chkBusiness.Location = new Point(222, 251);
            _chkBusiness.Name = "_chkBusiness";
            _chkBusiness.Size = new Size(155, 27);
            _chkBusiness.TabIndex = 5;
            _chkBusiness.Text = "was Businesstrip";
            _chkBusiness.UseVisualStyleBackColor = true;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 146);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 3;
            label3.Text = "Purpose of trip:";
            // 
            // _txtMilesDriven
            // 
            typedInputExtenderPanel1.SetErrorColor(_txtMilesDriven, null);
            typedInputExtenderPanel1.SetErrorText(_txtMilesDriven, "");
            typedInputExtenderPanel1.SetFocusColor(_txtMilesDriven, null);
            typedInputExtenderPanel1.SetFormatterComponent(_txtMilesDriven, null);
            _txtMilesDriven.Location = new Point(222, 410);
            _txtMilesDriven.Name = "_txtMilesDriven";
            _txtMilesDriven.Size = new Size(589, 30);
            _txtMilesDriven.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 413);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 10;
            label4.Text = "Miles driven";
            // 
            // _txtGallonsFuelUsed
            // 
            typedInputExtenderPanel1.SetErrorColor(_txtGallonsFuelUsed, null);
            typedInputExtenderPanel1.SetErrorText(_txtGallonsFuelUsed, "");
            typedInputExtenderPanel1.SetFocusColor(_txtGallonsFuelUsed, null);
            typedInputExtenderPanel1.SetFormatterComponent(_txtGallonsFuelUsed, null);
            _txtGallonsFuelUsed.Location = new Point(222, 457);
            _txtGallonsFuelUsed.Name = "_txtGallonsFuelUsed";
            _txtGallonsFuelUsed.Size = new Size(589, 30);
            _txtGallonsFuelUsed.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 460);
            label5.Name = "label5";
            label5.Size = new Size(144, 23);
            label5.TabIndex = 12;
            label5.Text = "Gallons fuel used:";
            // 
            // IntelligentAsyncEntryFormsView
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(typedInputExtenderPanel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "IntelligentAsyncEntryFormsView";
            Size = new Size(1024, 648);
            typedInputExtenderPanel1.ResumeLayout(false);
            typedInputExtenderPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dateFormatter).EndInit();
            ((System.ComponentModel.ISupportInitialize)_decimalFormatter).EndInit();
            ResumeLayout(false);
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
    }
}
