namespace DarkModeDemo
{
    partial class FormRenderTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRenderTest));
            TreeNode treeNode1 = new TreeNode("Node1");
            TreeNode treeNode2 = new TreeNode("Node0", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Node3");
            TreeNode treeNode4 = new TreeNode("Node5");
            TreeNode treeNode5 = new TreeNode("Node4", new TreeNode[] { treeNode4 });
            TreeNode treeNode6 = new TreeNode("Node2", new TreeNode[] { treeNode3, treeNode5 });
            TreeNode treeNode7 = new TreeNode("Node7");
            TreeNode treeNode8 = new TreeNode("Node11");
            TreeNode treeNode9 = new TreeNode("Node12");
            TreeNode treeNode10 = new TreeNode("Node13");
            TreeNode treeNode11 = new TreeNode("Node14");
            TreeNode treeNode12 = new TreeNode("Node10", new TreeNode[] { treeNode8, treeNode9, treeNode10, treeNode11 });
            TreeNode treeNode13 = new TreeNode("Node9", new TreeNode[] { treeNode12 });
            TreeNode treeNode14 = new TreeNode("Node8", new TreeNode[] { treeNode13 });
            TreeNode treeNode15 = new TreeNode("Node6", new TreeNode[] { treeNode7, treeNode14 });
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            domainUpDown1 = new DomainUpDown();
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            maskedTextBox1 = new MaskedTextBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            listBox1 = new ListBox();
            monthCalendar1 = new MonthCalendar();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            radioButton1 = new RadioButton();
            richTextBox1 = new RichTextBox();
            propertyGrid1 = new PropertyGrid();
            treeView1 = new TreeView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(29, 447);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(191, 50);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(29, 23);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(142, 34);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Entry 1", "Entry 2", "Entry 3", "Entry 4", "Entry 5", "Entry 6", "Entry 7", "Entry 8" });
            checkedListBox1.Location = new Point(29, 203);
            checkedListBox1.Margin = new Padding(4);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(240, 208);
            checkedListBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Entry 1", "Entry 2", "Entry 3", "Entry 4", "Entry 5", "Entry 6", "Entry 7", "Entry 8" });
            comboBox1.Location = new Point(25, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 38);
            comboBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(297, 23);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(325, 37);
            dateTimePicker1.TabIndex = 4;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(355, 115);
            domainUpDown1.Margin = new Padding(4);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(395, 37);
            domainUpDown1.TabIndex = 5;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(328, 178);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(817, 249);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(54, 169);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(249, 37);
            numericUpDown1.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(52, 107);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(230, 42);
            maskedTextBox1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(142, 54);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(109, 30);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 54);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Entry 1", "Entry 2", "Entry 3", "Entry 4", "Entry 5", "Entry 6", "Entry 7", "Entry 8", "Entry 1", "Entry 2", "Entry 3", "Entry 4", "Entry 5", "Entry 6", "Entry 7", "Entry 8" });
            listBox1.Location = new Point(50, 572);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(403, 274);
            listBox1.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(130, 30);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(monthCalendar1);
            panel1.Location = new Point(487, 549);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 334);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1398, 504);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 403);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(865, 72);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(612, 39);
            progressBar1.TabIndex = 11;
            progressBar1.Value = 40;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(26, 65);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(164, 34);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1180, 139);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(359, 318);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // propertyGrid1
            // 
            propertyGrid1.BackColor = SystemColors.Control;
            propertyGrid1.Location = new Point(1571, 41);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(376, 851);
            propertyGrid1.TabIndex = 14;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(1036, 507);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Name = "Node5";
            treeNode4.Text = "Node5";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Node4";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Node2";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Node7";
            treeNode8.Name = "Node11";
            treeNode8.Text = "Node11";
            treeNode9.Name = "Node12";
            treeNode9.Text = "Node12";
            treeNode10.Name = "Node13";
            treeNode10.Text = "Node13";
            treeNode11.Name = "Node14";
            treeNode11.Text = "Node14";
            treeNode12.Name = "Node10";
            treeNode12.Text = "Node10";
            treeNode13.Name = "Node9";
            treeNode13.Text = "Node9";
            treeNode14.Name = "Node8";
            treeNode14.Text = "Node8";
            treeNode15.Name = "Node6";
            treeNode15.Text = "Node6";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode2, treeNode6, treeNode15 });
            treeView1.Size = new Size(296, 388);
            treeView1.TabIndex = 15;
            // 
            // FormRenderTest
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1965, 928);
            Controls.Add(treeView1);
            Controls.Add(propertyGrid1);
            Controls.Add(richTextBox1);
            Controls.Add(radioButton1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(domainUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormRenderTest";
            Text = "FormRenderTest";
            VisualStylesMode = VisualStylesMode.Net10;
            Load += FormRenderTest_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private DomainUpDown domainUpDown1;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private MaskedTextBox maskedTextBox1;
        private LinkLabel linkLabel1;
        private Label label1;
        private ListBox listBox1;
        private MonthCalendar monthCalendar1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private RadioButton radioButton1;
        private RichTextBox richTextBox1;
        private PropertyGrid propertyGrid1;
        private TreeView treeView1;
    }
}