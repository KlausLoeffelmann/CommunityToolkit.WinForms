namespace WinFormsSkPlayGround.Views.Demos
{
    partial class AsyncDataForms
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            textBox4 = new TextBox();
            btnAddTodoItem = new Button();
            checkBox2 = new CheckBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(16, 321);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1059, 375);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Todo-Item";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Location = new Point(19, 53);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1017, 275);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 269);
            panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(192, 189);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(381, 42);
            textBox3.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 192);
            label2.Name = "label2";
            label2.Size = new Size(156, 30);
            label2.TabIndex = 8;
            label2.Text = "Hours needed:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(192, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(381, 42);
            textBox2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 130);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 6;
            label1.Text = "Date due:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 19);
            textBox1.Name = "textBox1";
            textBox1.Padding = new Padding(4);
            textBox1.PlaceholderText = "New Todo Item";
            textBox1.Size = new Size(561, 58);
            textBox1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox4);
            panel2.Location = new Point(603, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 269);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 19);
            label3.Name = "label3";
            label3.Size = new Size(75, 30);
            label3.TabIndex = 1;
            label3.Text = "Notes:";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(17, 65);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(376, 166);
            textBox4.TabIndex = 0;
            // 
            // btnAddTodoItem
            // 
            btnAddTodoItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddTodoItem.Location = new Point(1082, 374);
            btnAddTodoItem.Name = "btnAddTodoItem";
            btnAddTodoItem.Size = new Size(194, 57);
            btnAddTodoItem.TabIndex = 1;
            btnAddTodoItem.Text = "Add Item";
            btnAddTodoItem.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkBox2.Appearance = Appearance.ToggleSwitch;
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(1120, 493);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(93, 30);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "AI";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // AsyncDataForms
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddTodoItem);
            Controls.Add(groupBox1);
            Controls.Add(checkBox2);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AsyncDataForms";
            Size = new Size(1296, 730);
            VisualStylesMode = VisualStylesMode.Latest;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAddTodoItem;
        private CheckBox checkBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Panel panel2;
        private Label label3;
        private TextBox textBox4;
    }
}
