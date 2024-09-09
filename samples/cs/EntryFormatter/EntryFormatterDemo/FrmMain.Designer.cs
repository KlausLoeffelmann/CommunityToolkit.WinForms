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
            CommunityToolkit.WinForms.EntryFormatter.DecimalEntryFormatterComponent.DecimalDataEntryFormatter decimalDataEntryFormatter4 = new CommunityToolkit.WinForms.EntryFormatter.DecimalEntryFormatterComponent.DecimalDataEntryFormatter();
            CommunityToolkit.WinForms.EntryFormatter.DecimalEntryFormatterComponent.DecimalDataEntryFormatter decimalDataEntryFormatter3 = new CommunityToolkit.WinForms.EntryFormatter.DecimalEntryFormatterComponent.DecimalDataEntryFormatter();
            CommunityToolkit.WinForms.EntryFormatter.DecimalEntryFormatterComponent.DecimalDataEntryFormatter decimalDataEntryFormatter2 = new CommunityToolkit.WinForms.EntryFormatter.DecimalEntryFormatterComponent.DecimalDataEntryFormatter();
            CommunityToolkit.WinForms.EntryFormatter.DecimalEntryFormatterComponent.DecimalDataEntryFormatter decimalDataEntryFormatter1 = new CommunityToolkit.WinForms.EntryFormatter.DecimalEntryFormatterComponent.DecimalDataEntryFormatter();
            dateEntryFormatterComponent1 = new CommunityToolkit.WinForms.EntryFormatter.DateEntryFormatterComponent();
            decimalEntryFormatterComponent1 = new CommunityToolkit.WinForms.EntryFormatter.DecimalEntryFormatterComponent();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dataEntryPanel1 = new CommunityToolkit.WinForms.EntryFormatter.DataEntryPanel();
            ((System.ComponentModel.ISupportInitialize)dateEntryFormatterComponent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)decimalEntryFormatterComponent1).BeginInit();
            dataEntryPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateEntryFormatterComponent1
            // 
            dateEntryFormatterComponent1.ValueChanged += DateEntryFormatterComponent1_ValueChanged;
            // 
            // textBox1
            // 
            dataEntryPanel1.SetErrorColor(textBox1, null);
            dataEntryPanel1.SetErrorText(textBox1, "");
            dataEntryPanel1.SetFocusColor(textBox1, null);
            dataEntryPanel1.SetFormatterComponent(textBox1, decimalEntryFormatterComponent1);
            decimalDataEntryFormatter4.AllowFormular = true;
            decimalDataEntryFormatter4.CurrencySymbol = "$";
            decimalDataEntryFormatter4.DecimalPlaces = 2;
            decimalEntryFormatterComponent1.SetFormatterSettings(textBox1, decimalDataEntryFormatter4);
            textBox1.Location = new Point(30, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(685, 31);
            textBox1.TabIndex = 0;
            decimalEntryFormatterComponent1.SetValue(textBox1, new decimal(new int[] { 10, 0, 0, 0 }));
            // 
            // textBox2
            // 
            dataEntryPanel1.SetErrorColor(textBox2, null);
            dataEntryPanel1.SetErrorText(textBox2, "");
            dataEntryPanel1.SetFocusColor(textBox2, null);
            dataEntryPanel1.SetFormatterComponent(textBox2, decimalEntryFormatterComponent1);
            decimalDataEntryFormatter3.CurrencySymbol = "$";
            decimalDataEntryFormatter3.DecimalPlaces = 2;
            decimalEntryFormatterComponent1.SetFormatterSettings(textBox2, decimalDataEntryFormatter3);
            textBox2.Location = new Point(30, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(685, 31);
            textBox2.TabIndex = 1;
            decimalEntryFormatterComponent1.SetValue(textBox2, new decimal(new int[] { 20, 0, 0, 0 }));
            // 
            // textBox3
            // 
            dataEntryPanel1.SetErrorColor(textBox3, null);
            dataEntryPanel1.SetErrorText(textBox3, "");
            dataEntryPanel1.SetFocusColor(textBox3, null);
            dataEntryPanel1.SetFormatterComponent(textBox3, decimalEntryFormatterComponent1);
            decimalDataEntryFormatter2.CurrencySymbol = "$";
            decimalDataEntryFormatter2.DecimalPlaces = 2;
            decimalEntryFormatterComponent1.SetFormatterSettings(textBox3, decimalDataEntryFormatter2);
            textBox3.Location = new Point(30, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(685, 31);
            textBox3.TabIndex = 2;
            decimalEntryFormatterComponent1.SetValue(textBox3, new decimal(new int[] { 30, 0, 0, 0 }));
            // 
            // textBox4
            // 
            dataEntryPanel1.SetErrorColor(textBox4, null);
            dataEntryPanel1.SetErrorText(textBox4, "");
            dataEntryPanel1.SetFocusColor(textBox4, null);
            dataEntryPanel1.SetFormatterComponent(textBox4, decimalEntryFormatterComponent1);
            decimalDataEntryFormatter1.CurrencySymbol = "$";
            decimalDataEntryFormatter1.DecimalPlaces = 2;
            decimalEntryFormatterComponent1.SetFormatterSettings(textBox4, decimalDataEntryFormatter1);
            textBox4.Location = new Point(30, 203);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(685, 31);
            textBox4.TabIndex = 3;
            decimalEntryFormatterComponent1.SetValue(textBox4, new decimal(new int[] { 40, 0, 0, 0 }));
            // 
            // dataEntryPanel1
            // 
            dataEntryPanel1.Controls.Add(textBox4);
            dataEntryPanel1.Controls.Add(textBox3);
            dataEntryPanel1.Controls.Add(textBox2);
            dataEntryPanel1.Controls.Add(textBox1);
            dataEntryPanel1.Location = new Point(76, 65);
            dataEntryPanel1.Name = "dataEntryPanel1";
            dataEntryPanel1.Size = new Size(745, 489);
            dataEntryPanel1.TabIndex = 0;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 636);
            Controls.Add(dataEntryPanel1);
            Name = "FrmMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dateEntryFormatterComponent1).EndInit();
            ((System.ComponentModel.ISupportInitialize)decimalEntryFormatterComponent1).EndInit();
            dataEntryPanel1.ResumeLayout(false);
            dataEntryPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CommunityToolkit.WinForms.EntryFormatter.DateEntryFormatterComponent dateEntryFormatterComponent1;
        private CommunityToolkit.WinForms.EntryFormatter.DecimalEntryFormatterComponent decimalEntryFormatterComponent1;
        private CommunityToolkit.WinForms.EntryFormatter.DataEntryPanel dataEntryPanel1;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}
