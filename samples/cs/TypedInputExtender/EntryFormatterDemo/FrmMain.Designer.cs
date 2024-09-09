namespace EntryFormatterDemo
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter decimalDataEntryFormatter5 = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter();
            CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter decimalDataEntryFormatter4 = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter();
            CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter decimalDataEntryFormatter3 = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter();
            CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter decimalDataEntryFormatter2 = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter();
            _dateFormatterComponent = new CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent();
            _decimalFormatterComponent = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dataEntryPanel1 = new CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)_dateFormatterComponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_decimalFormatterComponent).BeginInit();
            dataEntryPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // _decimalFormatterComponent
            // 
            _decimalFormatterComponent.ValueChanged += DecimalFormatter_ValueChanged;
            // 
            // textBox1
            // 
            dataEntryPanel1.SetErrorColor(textBox1, null);
            dataEntryPanel1.SetErrorText(textBox1, "");
            dataEntryPanel1.SetFocusColor(textBox1, null);
            dataEntryPanel1.SetFormatterComponent(textBox1, _decimalFormatterComponent);
            decimalDataEntryFormatter5.AllowFormular = true;
            decimalDataEntryFormatter5.CurrencySymbol = "$";
            decimalDataEntryFormatter5.DecimalPlaces = 2;
            _decimalFormatterComponent.SetFormatterSettings(textBox1, decimalDataEntryFormatter5);
            textBox1.Location = new Point(30, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(685, 31);
            textBox1.TabIndex = 0;
            _decimalFormatterComponent.SetValue(textBox1, new decimal(new int[] { 10, 0, 0, 0 }));
            // 
            // textBox2
            // 
            dataEntryPanel1.SetErrorColor(textBox2, null);
            dataEntryPanel1.SetErrorText(textBox2, "");
            dataEntryPanel1.SetFocusColor(textBox2, null);
            dataEntryPanel1.SetFormatterComponent(textBox2, _decimalFormatterComponent);
            decimalDataEntryFormatter4.CurrencySymbol = "$";
            decimalDataEntryFormatter4.DecimalPlaces = 2;
            _decimalFormatterComponent.SetFormatterSettings(textBox2, decimalDataEntryFormatter4);
            textBox2.Location = new Point(30, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(685, 31);
            textBox2.TabIndex = 1;
            _decimalFormatterComponent.SetValue(textBox2, new decimal(new int[] { 20, 0, 0, 0 }));
            // 
            // textBox3
            // 
            dataEntryPanel1.SetErrorColor(textBox3, null);
            dataEntryPanel1.SetErrorText(textBox3, "");
            dataEntryPanel1.SetFocusColor(textBox3, null);
            dataEntryPanel1.SetFormatterComponent(textBox3, _decimalFormatterComponent);
            decimalDataEntryFormatter3.CurrencySymbol = "$";
            decimalDataEntryFormatter3.DecimalPlaces = 2;
            _decimalFormatterComponent.SetFormatterSettings(textBox3, decimalDataEntryFormatter3);
            textBox3.Location = new Point(30, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(685, 31);
            textBox3.TabIndex = 2;
            _decimalFormatterComponent.SetValue(textBox3, new decimal(new int[] { 30, 0, 0, 0 }));
            // 
            // textBox4
            // 
            dataEntryPanel1.SetErrorColor(textBox4, null);
            dataEntryPanel1.SetErrorText(textBox4, "");
            dataEntryPanel1.SetFocusColor(textBox4, null);
            dataEntryPanel1.SetFormatterComponent(textBox4, _decimalFormatterComponent);
            decimalDataEntryFormatter2.CurrencySymbol = "$";
            decimalDataEntryFormatter2.DecimalPlaces = 2;
            _decimalFormatterComponent.SetFormatterSettings(textBox4, decimalDataEntryFormatter2);
            textBox4.Location = new Point(30, 203);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(685, 31);
            textBox4.TabIndex = 3;
            _decimalFormatterComponent.SetValue(textBox4, new decimal(new int[] { 40, 0, 0, 0 }));
            // 
            // dataEntryPanel1
            // 
            dataEntryPanel1.Controls.Add(label1);
            dataEntryPanel1.Controls.Add(textBox4);
            dataEntryPanel1.Controls.Add(textBox3);
            dataEntryPanel1.Controls.Add(textBox2);
            dataEntryPanel1.Controls.Add(textBox1);
            dataEntryPanel1.Location = new Point(76, 65);
            dataEntryPanel1.Name = "dataEntryPanel1";
            dataEntryPanel1.Size = new Size(745, 489);
            dataEntryPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 301);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 636);
            Controls.Add(dataEntryPanel1);
            Name = "FrmMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)_dateFormatterComponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)_decimalFormatterComponent).EndInit();
            dataEntryPanel1.ResumeLayout(false);
            dataEntryPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent _dateFormatterComponent;
        private CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent _decimalFormatterComponent;
        private CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel dataEntryPanel1;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label1;
    }
}
