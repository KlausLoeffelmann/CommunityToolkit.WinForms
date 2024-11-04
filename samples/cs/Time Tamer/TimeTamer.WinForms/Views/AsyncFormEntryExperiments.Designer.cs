namespace TaskTamer9.WinForms.Views
{
    partial class AsyncFormEntryExperiments
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter decimalFormatter1 = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter();
            typedInputExtenderPanel1 = new CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel();
            textBox1 = new TextBox();
            _dateFormatterComponent = new CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent();
            decimalFormatterComponent1 = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent();
            typedInputExtenderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dateFormatterComponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)decimalFormatterComponent1).BeginInit();
            SuspendLayout();
            // 
            // typedInputExtenderPanel1
            // 
            typedInputExtenderPanel1.Controls.Add(textBox1);
            typedInputExtenderPanel1.Location = new Point(22, 26);
            typedInputExtenderPanel1.Name = "typedInputExtenderPanel1";
            typedInputExtenderPanel1.Size = new Size(745, 352);
            typedInputExtenderPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            typedInputExtenderPanel1.SetErrorColor(textBox1, null);
            typedInputExtenderPanel1.SetErrorText(textBox1, "");
            typedInputExtenderPanel1.SetFocusColor(textBox1, null);
            typedInputExtenderPanel1.SetFormatterComponent(textBox1, decimalFormatterComponent1);
            decimalFormatter1.CurrencySymbol = null;
            decimalFormatter1.DecimalPlaces = 0;
            decimalFormatterComponent1.SetFormatterSettings(textBox1, decimalFormatter1);
            textBox1.Location = new Point(37, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 23);
            textBox1.TabIndex = 0;
            decimalFormatterComponent1.SetValue(textBox1, null);
            // 
            // AsyncFormEntryExperiments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(typedInputExtenderPanel1);
            Name = "AsyncFormEntryExperiments";
            Text = "Async Form Entry Experiments";
            typedInputExtenderPanel1.ResumeLayout(false);
            typedInputExtenderPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dateFormatterComponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)decimalFormatterComponent1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel typedInputExtenderPanel1;
        private TextBox textBox1;
        private CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent _dateFormatterComponent;
        private CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent decimalFormatterComponent1;
    }
}