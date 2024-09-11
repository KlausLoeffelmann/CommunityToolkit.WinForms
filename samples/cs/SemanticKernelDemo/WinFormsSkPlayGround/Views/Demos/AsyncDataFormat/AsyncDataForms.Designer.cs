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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label4 = new Label();
            _txtHoursNeeded = new TextBox();
            label2 = new Label();
            _txtDateDue = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            _txtNotes = new TextBox();
            _btnAddTodoItem = new Button();
            _chkAISupport = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            _taskGridView = new CommunityToolkit.WinForms.GridView.GridView();
            _mainViewModelSource = new BindingSource(components);
            _taskViewItem = new TaskTamer9.WinForms.Views.TaskViewItem();
            taskViewModelBindingSource = new BindingSource(components);
            _dateFormatter = new CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent();
            _decimalFormatter = new CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent();
            _txtTodoItemText = new TextBox();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_taskGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_mainViewModelSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskViewModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dateFormatter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_decimalFormatter).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(4, 400);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1088, 326);
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
            tableLayoutPanel1.Location = new Point(19, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1062, 276);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(_txtHoursNeeded);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(_txtDateDue);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(_txtTodoItemText);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 270);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(192, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(381, 42);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(106, 30);
            label4.TabIndex = 3;
            label4.Text = "Date due:";
            // 
            // _txtHoursNeeded
            // 
            _txtHoursNeeded.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _txtHoursNeeded.Location = new Point(192, 208);
            _txtHoursNeeded.Name = "_txtHoursNeeded";
            _txtHoursNeeded.Size = new Size(381, 42);
            _txtHoursNeeded.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 211);
            label2.Name = "label2";
            label2.Size = new Size(156, 30);
            label2.TabIndex = 5;
            label2.Text = "Hours needed:";
            // 
            // _txtDateDue
            // 
            _txtDateDue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _txtDateDue.Location = new Point(192, 93);
            _txtDateDue.Name = "_txtDateDue";
            _txtDateDue.Size = new Size(381, 42);
            _txtDateDue.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 1;
            label1.Text = "Date due:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(_txtNotes);
            panel2.Location = new Point(603, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 270);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 19);
            label3.Name = "label3";
            label3.Size = new Size(75, 30);
            label3.TabIndex = 0;
            label3.Text = "Notes:";
            // 
            // _txtNotes
            // 
            _txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _txtNotes.Location = new Point(17, 55);
            _txtNotes.Multiline = true;
            _txtNotes.Name = "_txtNotes";
            _txtNotes.Size = new Size(428, 195);
            _txtNotes.TabIndex = 1;
            // 
            // _btnAddTodoItem
            // 
            _btnAddTodoItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _btnAddTodoItem.Location = new Point(12, 13);
            _btnAddTodoItem.Name = "_btnAddTodoItem";
            _btnAddTodoItem.Size = new Size(167, 57);
            _btnAddTodoItem.TabIndex = 0;
            _btnAddTodoItem.Text = "Add Item";
            _btnAddTodoItem.UseVisualStyleBackColor = true;
            // 
            // _chkAISupport
            // 
            _chkAISupport.Anchor = AnchorStyles.Top;
            _chkAISupport.Appearance = Appearance.ToggleSwitch;
            _chkAISupport.AutoSize = true;
            _chkAISupport.Location = new Point(46, 94);
            _chkAISupport.Name = "_chkAISupport";
            _chkAISupport.Size = new Size(93, 30);
            _chkAISupport.TabIndex = 1;
            _chkAISupport.Text = "AI";
            _chkAISupport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.Controls.Add(panel3, 1, 1);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel2.Controls.Add(_taskGridView, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1296, 730);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(_btnAddTodoItem);
            panel3.Controls.Add(_chkAISupport);
            panel3.Location = new Point(1099, 399);
            panel3.Name = "panel3";
            panel3.Size = new Size(194, 328);
            panel3.TabIndex = 1;
            // 
            // _taskGridView
            // 
            _taskGridView.AllowUserToAddRows = false;
            _taskGridView.AllowUserToDeleteRows = false;
            _taskGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.SetColumnSpan(_taskGridView, 2);
            _taskGridView.DataBindings.Add(new Binding("SelectedItem", _mainViewModelSource, "SelectedTask", true));
            _taskGridView.DataBindings.Add(new Binding("DataContext", _mainViewModelSource, "Tasks", true));
            _taskGridView.GridViewItemTemplate = _taskViewItem;
            _taskGridView.Location = new Point(3, 3);
            _taskGridView.Name = "_taskGridView";
            _taskGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _taskGridView.Size = new Size(1290, 390);
            _taskGridView.TabIndex = 2;
            _taskGridView.VirtualMode = true;
            // 
            // _mainViewModelSource
            // 
            _mainViewModelSource.DataSource = typeof(TaskTamer.ViewModels.MainViewModel);
            // 
            // _taskViewItem
            // 
            _taskViewItem.DataBindings.Add(new Binding("DueDate", taskViewModelBindingSource, "DueDate", true));
            _taskViewItem.DataBindings.Add(new Binding("Project", taskViewModelBindingSource, "Project", true));
            _taskViewItem.DataBindings.Add(new Binding("TaskDescription", taskViewModelBindingSource, "Description", true));
            _taskViewItem.DataBindings.Add(new Binding("TaskName", taskViewModelBindingSource, "Name", true));
            _taskViewItem.DataBindings.Add(new Binding("TaskStatus", taskViewModelBindingSource, "Status", true));
            _taskViewItem.DescriptionFont = new Font("Segoe UI", 16F, FontStyle.Bold);
            _taskViewItem.NameFont = new Font("Segoe UI", 16F, FontStyle.Bold);
            // 
            // taskViewModelBindingSource
            // 
            taskViewModelBindingSource.DataSource = typeof(TaskTamer.ViewModels.TaskViewModel);
            // 
            // _txtTodoItemText
            // 
            _txtTodoItemText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _txtTodoItemText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _txtTodoItemText.Location = new Point(12, 19);
            _txtTodoItemText.Name = "_txtTodoItemText";
            _txtTodoItemText.Padding = new Padding(4);
            _txtTodoItemText.PlaceholderText = "New Todo Item";
            _txtTodoItemText.Size = new Size(561, 45);
            _txtTodoItemText.TabIndex = 0;
            // 
            // AsyncDataForms
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
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
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_taskGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)_mainViewModelSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskViewModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dateFormatter).EndInit();
            ((System.ComponentModel.ISupportInitialize)_decimalFormatter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button _btnAddTodoItem;
        private CheckBox _chkAISupport;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox _txtHoursNeeded;
        private Label label2;
        private TextBox _txtDateDue;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private TextBox _txtNotes;
        private TextBox textBox1;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private CommunityToolkit.WinForms.GridView.GridView _taskGridView;
        private CommunityToolkit.WinForms.TypedInputExtenders.DateFormatterComponent _dateFormatter;
        private CommunityToolkit.WinForms.TypedInputExtenders.DecimalFormatterComponent _decimalFormatter;
        private BindingSource _mainViewModelSource;
        private TaskTamer9.WinForms.Views.TaskViewItem _taskViewItem;
        private BindingSource taskViewModelBindingSource;
        private SemanticKernelDemo.SemanticKernel.SemanticKernelComponent semanticKernelConversation1;
        private TextBox _txtTodoItemText;
    }
}
