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
            CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent.DateFormatter dateFormatter1 = new CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent.DateFormatter();
            typedInputExtenderPanel1 = new CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            _decimalFormatter = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent();
            _dateFormatter = new CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent();
            button1 = new Button();
            _stringSpellAndGrammarChecker = new CommunityToolkit.WinForms.AI.StringSpellAndGrammarChecker();
            _btnTestSemanticKernel = new Button();
            typedInputExtenderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_decimalFormatter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dateFormatter).BeginInit();
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
            typedInputExtenderPanel1.Size = new Size(754, 156);
            typedInputExtenderPanel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(187, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(541, 33);
            comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 100);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 2;
            label4.Text = "Categories";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 25);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 0;
            label3.Text = "New Todo Item";
            // 
            // textBox3
            // 
            typedInputExtenderPanel1.SetErrorColor(textBox3, null);
            typedInputExtenderPanel1.SetErrorText(textBox3, "");
            typedInputExtenderPanel1.SetFocusColor(textBox3, Color.Yellow);
            typedInputExtenderPanel1.SetFormatterComponent(textBox3, _decimalFormatter);
            decimalFormatter1.CurrencySymbol = null;
            decimalFormatter1.DecimalPlaces = 0;
            _decimalFormatter.SetFormatterSettings(textBox3, decimalFormatter1);
            textBox3.Location = new Point(187, 22);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(541, 31);
            textBox3.TabIndex = 1;
            _decimalFormatter.SetValue(textBox3, null);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 64);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 6;
            label2.Text = "Due date:";
            // 
            // textBox2
            // 
            typedInputExtenderPanel1.SetErrorColor(textBox2, null);
            typedInputExtenderPanel1.SetErrorText(textBox2, "");
            typedInputExtenderPanel1.SetFocusColor(textBox2, Color.Yellow);
            typedInputExtenderPanel1.SetFormatterComponent(textBox2, _decimalFormatter);
            decimalFormatter2.CurrencySymbol = null;
            decimalFormatter2.DecimalPlaces = 0;
            _decimalFormatter.SetFormatterSettings(textBox2, decimalFormatter2);
            textBox2.Location = new Point(500, 61);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 31);
            textBox2.TabIndex = 7;
            _decimalFormatter.SetValue(textBox2, null);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 64);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 4;
            label1.Text = "Start date:";
            // 
            // textBox1
            // 
            typedInputExtenderPanel1.SetErrorColor(textBox1, Color.Red);
            typedInputExtenderPanel1.SetErrorText(textBox1, "");
            typedInputExtenderPanel1.SetFocusColor(textBox1, Color.Yellow);
            typedInputExtenderPanel1.SetFormatterComponent(textBox1, _dateFormatter);
            _dateFormatter.SetFormatterSettings(textBox1, dateFormatter1);
            textBox1.Location = new Point(187, 61);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 31);
            textBox1.TabIndex = 5;
            _dateFormatter.SetValue(textBox1, new DateTime(0L));
            // 
            // button1
            // 
            button1.Location = new Point(332, 192);
            button1.Name = "button1";
            button1.Size = new Size(117, 44);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // _btnTestSemanticKernel
            // 
            _btnTestSemanticKernel.Location = new Point(649, 192);
            _btnTestSemanticKernel.Name = "_btnTestSemanticKernel";
            _btnTestSemanticKernel.Size = new Size(117, 44);
            _btnTestSemanticKernel.TabIndex = 2;
            _btnTestSemanticKernel.Text = "Test AI";
            _btnTestSemanticKernel.UseVisualStyleBackColor = true;
            _btnTestSemanticKernel.Click += BtnTestSemanticKernel_Click;
            // 
            // FrmAsyncExperiments
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 262);
            Controls.Add(_btnTestSemanticKernel);
            Controls.Add(button1);
            Controls.Add(typedInputExtenderPanel1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmAsyncExperiments";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Async Form Entry Experiments";
            typedInputExtenderPanel1.ResumeLayout(false);
            typedInputExtenderPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_decimalFormatter).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dateFormatter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CommunityToolkit.WinForms.TypedInputExtenders.TypedInputExtenderPanel typedInputExtenderPanel1;
        private TextBox textBox1;
        private CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent _dateFormatter;
        private CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent _decimalFormatter;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label4;
        private CommunityToolkit.WinForms.AI.StringSpellAndGrammarChecker _stringSpellAndGrammarChecker;
        private Button _btnTestSemanticKernel;
    }
}