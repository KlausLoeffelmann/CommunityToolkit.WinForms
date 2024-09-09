namespace DarkModeDemo
{
    partial class FormArrangeElementTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArrangeElementTest));
            textBoxEx1 = new ArrangeElement.TextBoxEx();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            richTextBox1 = new RichTextBox();
            maskedTextBox1 = new MaskedTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxEx1
            // 
            textBoxEx1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEx1.Location = new Point(309, 10);
            textBoxEx1.Margin = new Padding(10);
            textBoxEx1.Name = "textBoxEx1";
            textBoxEx1.Padding = new Padding(2);
            textBoxEx1.Size = new Size(279, 40);
            textBoxEx1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(textBoxEx1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 1);
            tableLayoutPanel1.Location = new Point(72, 175);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(598, 170);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 34);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 36);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(302, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 36);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(59, 32);
            textBox4.Name = "textBox4";
            textBox4.Padding = new Padding(10);
            textBox4.Size = new Size(367, 54);
            textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(726, 32);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Padding = new Padding(15, 15, 2, 15);
            textBox5.ScrollBars = ScrollBars.Both;
            textBox5.Size = new Size(719, 562);
            textBox5.TabIndex = 3;
            textBox5.Text = "jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhgjh g";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(75, 483);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            richTextBox1.Size = new Size(397, 171);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "jhhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhg jhgj g";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(75, 394);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Padding = new Padding(10);
            maskedTextBox1.Size = new Size(370, 56);
            maskedTextBox1.TabIndex = 5;
            // 
            // FormArrangeElementTest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 700);
            Controls.Add(maskedTextBox1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(tableLayoutPanel1);
            Name = "FormArrangeElementTest";
            Text = "FormArrangeElementTest";
            VisualStylesMode = VisualStylesMode.Latest;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ArrangeElement.TextBoxEx textBoxEx1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private RichTextBox richTextBox1;
        private MaskedTextBox maskedTextBox1;
    }
}