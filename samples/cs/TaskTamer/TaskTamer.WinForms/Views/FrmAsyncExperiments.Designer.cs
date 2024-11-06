namespace TaskTamer9.WinForms.Views
{
    partial class FrmAsyncExperiments
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
            CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter decimalFormatter2 = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter();
            CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter decimalFormatter3 = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent.DecimalFormatter();
            typedInputExtenderPanel1 = new CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            decimalFormatterComponent1 = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent();
            _dateFormatterComponent = new CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent();
            button1 = new Button();
            typedInputExtenderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)decimalFormatterComponent1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dateFormatterComponent).BeginInit();
            SuspendLayout();
            // 
            // typedInputExtenderPanel1
            // 
            typedInputExtenderPanel1.Controls.Add(comboBox1);
            typedInputExtenderPanel1.Controls.Add(label4);
            typedInputExtenderPanel1.Controls.Add(label3);
            typedInputExtenderPanel1.Controls.Add(textBox3);
            typedInputExtenderPanel1.Controls.Add(label2);
            typedInputExtenderPanel1.Controls.Add(textBox2);
            typedInputExtenderPanel1.Controls.Add(label1);
            typedInputExtenderPanel1.Controls.Add(textBox1);
            typedInputExtenderPanel1.Location = new Point(12, 13);
            typedInputExtenderPanel1.Margin = new Padding(3, 4, 3, 4);
            typedInputExtenderPanel1.Name = "typedInputExtenderPanel1";
            typedInputExtenderPanel1.Size = new Size(754, 157);
            typedInputExtenderPanel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(187, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(541, 27);
            comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 65);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 2;
            label4.Text = "Start date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 25);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 0;
            label3.Text = "New Todo Item";
            // 
            // textBox3
            // 
            typedInputExtenderPanel1.SetErrorColor(textBox3, null);
            typedInputExtenderPanel1.SetErrorText(textBox3, "");
            typedInputExtenderPanel1.SetFocusColor(textBox3, null);
            typedInputExtenderPanel1.SetFormatterComponent(textBox3, decimalFormatterComponent1);
            decimalFormatter1.CurrencySymbol = null;
            decimalFormatter1.DecimalPlaces = 0;
            decimalFormatterComponent1.SetFormatterSettings(textBox3, decimalFormatter1);
            textBox3.Location = new Point(187, 22);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(541, 27);
            textBox3.TabIndex = 1;
            decimalFormatterComponent1.SetValue(textBox3, null);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 105);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 6;
            label2.Text = "Due date:";
            // 
            // textBox2
            // 
            typedInputExtenderPanel1.SetErrorColor(textBox2, null);
            typedInputExtenderPanel1.SetErrorText(textBox2, "");
            typedInputExtenderPanel1.SetFocusColor(textBox2, null);
            typedInputExtenderPanel1.SetFormatterComponent(textBox2, decimalFormatterComponent1);
            decimalFormatter2.CurrencySymbol = null;
            decimalFormatter2.DecimalPlaces = 0;
            decimalFormatterComponent1.SetFormatterSettings(textBox2, decimalFormatter2);
            textBox2.Location = new Point(500, 102);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 27);
            textBox2.TabIndex = 7;
            decimalFormatterComponent1.SetValue(textBox2, null);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 105);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 4;
            label1.Text = "Start date:";
            // 
            // textBox1
            // 
            typedInputExtenderPanel1.SetErrorColor(textBox1, null);
            typedInputExtenderPanel1.SetErrorText(textBox1, "");
            typedInputExtenderPanel1.SetFocusColor(textBox1, null);
            typedInputExtenderPanel1.SetFormatterComponent(textBox1, decimalFormatterComponent1);
            decimalFormatter3.CurrencySymbol = null;
            decimalFormatter3.DecimalPlaces = 0;
            decimalFormatterComponent1.SetFormatterSettings(textBox1, decimalFormatter3);
            textBox1.Location = new Point(187, 102);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 5;
            decimalFormatterComponent1.SetValue(textBox1, null);
            // 
            // button1
            // 
            button1.Location = new Point(354, 187);
            button1.Name = "button1";
            button1.Size = new Size(117, 44);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // AsyncFormEntryExperiments
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 239);
            Controls.Add(button1);
            Controls.Add(typedInputExtenderPanel1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AsyncFormEntryExperiments";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Async Form Entry Experiments";
            typedInputExtenderPanel1.ResumeLayout(false);
            typedInputExtenderPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)decimalFormatterComponent1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dateFormatterComponent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel typedInputExtenderPanel1;
        private TextBox textBox1;
        private CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent _dateFormatterComponent;
        private CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent decimalFormatterComponent1;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label4;
    }
}