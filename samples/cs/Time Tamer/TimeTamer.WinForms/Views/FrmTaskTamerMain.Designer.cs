using DemoToolkit.Mvvm.WinForms.Controls;
using DemoToolkit.Mvvm.WinForms.Controls.ModernEntry;

namespace TaskTamer.WinForms
{
    partial class FrmTaskTamerMain
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
            components = new System.ComponentModel.Container();
            _statusStrip = new StatusStrip();
            _lblSortOrder = new ToolStripStatusLabel();
            _mainVmSource = new BindingSource(components);
            _lblSelectedTasksProjectInfo = new ToolStripStatusLabel();
            _lblCurrentUser = new ToolStripStatusLabel();
            _lblDateTime = new ToolStripStatusLabel();
            _mainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            quitToolStripMenuItem = new ToolStripMenuItem();
            baseDataToolStripMenuItem = new ToolStripMenuItem();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            prToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            usersToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            orderByDueDateToolStripMenuItem = new ToolStripMenuItem();
            orderByLastModifiedToolStripMenuItem = new ToolStripMenuItem();
            orderByStatusToolStripMenuItem = new ToolStripMenuItem();
            testsToolStripMenuItem = new ToolStripMenuItem();
            _demoInvokeAsyncMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            _tasksGridView = new GridView();
            _taskViewItem = new TaskTamer9.WinForms.Views.TaskViewItem();
            _taskVmSource = new BindingSource(components);
            _projectsSource = new BindingSource(components);
            _semanticKernelComponent = new DemoToolkit.Mvvm.WinForms.AI.SemanticKernelBaseComponent();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label4 = new Label();
            _txtDateDue = new TextBox();
            label1 = new Label();
            _txtTodoItemText = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            _txtNotes = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            _statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_mainVmSource).BeginInit();
            _mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_tasksGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_taskVmSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_projectsSource).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // _statusStrip
            // 
            _statusStrip.Font = new Font("Segoe UI", 12F);
            _statusStrip.GripMargin = new Padding(5);
            _statusStrip.GripStyle = ToolStripGripStyle.Visible;
            _statusStrip.ImageScalingSize = new Size(20, 20);
            _statusStrip.Items.AddRange(new ToolStripItem[] { _lblSortOrder, _lblSelectedTasksProjectInfo, _lblCurrentUser, _lblDateTime });
            _statusStrip.Location = new Point(0, 792);
            _statusStrip.Margin = new Padding(0, 0, 3, 0);
            _statusStrip.Name = "_statusStrip";
            _statusStrip.Padding = new Padding(1, 0, 18, 0);
            _statusStrip.Size = new Size(1427, 36);
            _statusStrip.TabIndex = 3;
            _statusStrip.Text = "statusStrip1";
            // 
            // _lblSortOrder
            // 
            _lblSortOrder.BackColor = Color.DeepSkyBlue;
            _lblSortOrder.DataBindings.Add(new Binding("Text", _mainVmSource, "SortOrder", true, DataSourceUpdateMode.OnPropertyChanged));
            _lblSortOrder.Name = "_lblSortOrder";
            _lblSortOrder.Size = new Size(98, 31);
            _lblSortOrder.Text = "#SortOrder#";
            // 
            // _mainVmSource
            // 
            _mainVmSource.DataSource = typeof(ViewModels.MainViewModel);
            // 
            // _lblSelectedTasksProjectInfo
            // 
            _lblSelectedTasksProjectInfo.DataBindings.Add(new Binding("Text", _mainVmSource, "SelectedTask", true, DataSourceUpdateMode.Never));
            _lblSelectedTasksProjectInfo.Name = "_lblSelectedTasksProjectInfo";
            _lblSelectedTasksProjectInfo.Size = new Size(1339, 31);
            _lblSelectedTasksProjectInfo.Spring = true;
            _lblSelectedTasksProjectInfo.Text = "#SelectedTasksProjectSpring#";
            _lblSelectedTasksProjectInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _lblCurrentUser
            // 
            _lblCurrentUser.DataBindings.Add(new Binding("Text", _mainVmSource, "CurrentUser", true));
            _lblCurrentUser.Name = "_lblCurrentUser";
            _lblCurrentUser.Size = new Size(60, 31);
            _lblCurrentUser.Text = "#User#";
            // 
            // _lblDateTime
            // 
            _lblDateTime.DataBindings.Add(new Binding("Text", _mainVmSource, "CurrentDisplayTime", true));
            _lblDateTime.DisplayStyle = ToolStripItemDisplayStyle.Text;
            _lblDateTime.Margin = new Padding(0, 3, 2, 2);
            _lblDateTime.Name = "_lblDateTime";
            _lblDateTime.Padding = new Padding(5);
            _lblDateTime.Size = new Size(151, 31);
            _lblDateTime.Text = "#DatePlaceholder#";
            // 
            // _mainMenuStrip
            // 
            _mainMenuStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _mainMenuStrip.ImageScalingSize = new Size(20, 20);
            _mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, baseDataToolStripMenuItem, toolStripMenuItem3, testsToolStripMenuItem, toolsToolStripMenuItem });
            _mainMenuStrip.Location = new Point(0, 0);
            _mainMenuStrip.Name = "_mainMenuStrip";
            _mainMenuStrip.Padding = new Padding(13, 6, 6, 6);
            _mainMenuStrip.Size = new Size(1427, 37);
            _mainMenuStrip.TabIndex = 0;
            _mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportToolStripMenuItem, importToolStripMenuItem, toolStripMenuItem1, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 25);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(136, 26);
            exportToolStripMenuItem.Text = "&Export...";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(136, 26);
            importToolStripMenuItem.Text = "&Import...";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(133, 6);
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(136, 26);
            quitToolStripMenuItem.Text = "&Quit";
            // 
            // baseDataToolStripMenuItem
            // 
            baseDataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriesToolStripMenuItem, prToolStripMenuItem, toolStripMenuItem2, usersToolStripMenuItem });
            baseDataToolStripMenuItem.Name = "baseDataToolStripMenuItem";
            baseDataToolStripMenuItem.Size = new Size(48, 25);
            baseDataToolStripMenuItem.Text = "Edit";
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(163, 26);
            categoriesToolStripMenuItem.Text = "Categories...";
            // 
            // prToolStripMenuItem
            // 
            prToolStripMenuItem.Name = "prToolStripMenuItem";
            prToolStripMenuItem.Size = new Size(163, 26);
            prToolStripMenuItem.Text = "&Projects...";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(160, 6);
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(163, 26);
            usersToolStripMenuItem.Text = "Users...";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { orderByDueDateToolStripMenuItem, orderByLastModifiedToolStripMenuItem, orderByStatusToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(56, 25);
            toolStripMenuItem3.Text = "View";
            // 
            // orderByDueDateToolStripMenuItem
            // 
            orderByDueDateToolStripMenuItem.DataBindings.Add(new Binding("Command", _mainVmSource, "SetSortOrderCommand", true));
            orderByDueDateToolStripMenuItem.Name = "orderByDueDateToolStripMenuItem";
            orderByDueDateToolStripMenuItem.Size = new Size(240, 26);
            orderByDueDateToolStripMenuItem.Text = "Order by Due Date";
            // 
            // orderByLastModifiedToolStripMenuItem
            // 
            orderByLastModifiedToolStripMenuItem.DataBindings.Add(new Binding("Command", _mainVmSource, "SetSortOrderCommand", true));
            orderByLastModifiedToolStripMenuItem.Name = "orderByLastModifiedToolStripMenuItem";
            orderByLastModifiedToolStripMenuItem.Size = new Size(240, 26);
            orderByLastModifiedToolStripMenuItem.Text = "Order by Last Modified";
            // 
            // orderByStatusToolStripMenuItem
            // 
            orderByStatusToolStripMenuItem.DataBindings.Add(new Binding("Command", _mainVmSource, "SetSortOrderCommand", true));
            orderByStatusToolStripMenuItem.Name = "orderByStatusToolStripMenuItem";
            orderByStatusToolStripMenuItem.Size = new Size(240, 26);
            orderByStatusToolStripMenuItem.Text = "Order by Status";
            // 
            // testsToolStripMenuItem
            // 
            testsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _demoInvokeAsyncMenuItem });
            testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            testsToolStripMenuItem.Size = new Size(64, 25);
            testsToolStripMenuItem.Text = "&Demo";
            // 
            // _demoInvokeAsyncMenuItem
            // 
            _demoInvokeAsyncMenuItem.Name = "_demoInvokeAsyncMenuItem";
            _demoInvokeAsyncMenuItem.Size = new Size(214, 26);
            _demoInvokeAsyncMenuItem.Text = "Async in WinForms";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(57, 25);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(144, 26);
            optionsToolStripMenuItem.Text = "&Options...";
            // 
            // _tasksGridView
            // 
            _tasksGridView.AllowUserToAddRows = false;
            _tasksGridView.AllowUserToDeleteRows = false;
            _tasksGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _tasksGridView.BorderStyle = BorderStyle.None;
            _tasksGridView.DataBindings.Add(new Binding("SelectedItem", _mainVmSource, "SelectedTask", true, DataSourceUpdateMode.OnPropertyChanged));
            _tasksGridView.DataBindings.Add(new Binding("DataContext", _mainVmSource, "Tasks", true));
            _tasksGridView.GridViewItemTemplate = _taskViewItem;
            _tasksGridView.Location = new Point(13, 41);
            _tasksGridView.Margin = new Padding(4);
            _tasksGridView.Name = "_tasksGridView";
            _tasksGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _tasksGridView.Size = new Size(1397, 487);
            _tasksGridView.TabIndex = 1;
            _tasksGridView.VirtualMode = true;
            // 
            // _taskViewItem
            // 
            _taskViewItem.ContentPadding = new Padding(5);
            _taskViewItem.DataBindings.Add(new Binding("TaskName", _taskVmSource, "Name", true));
            _taskViewItem.DataBindings.Add(new Binding("TaskStatus", _taskVmSource, "Status", true));
            _taskViewItem.DataBindings.Add(new Binding("Project", _taskVmSource, "Project", true));
            _taskViewItem.DataBindings.Add(new Binding("DueDate", _taskVmSource, "DueDate", true));
            _taskViewItem.DataBindings.Add(new Binding("TaskDescription", _taskVmSource, "Description", true));
            _taskViewItem.DescriptionFont = new Font("Segoe UI", 16F, FontStyle.Bold);
            _taskViewItem.NameFont = new Font("Segoe UI", 16F, FontStyle.Bold);
            // 
            // _taskVmSource
            // 
            _taskVmSource.DataSource = typeof(ViewModels.TaskViewModel);
            // 
            // _projectsSource
            // 
            _projectsSource.DataMember = "Projects";
            _projectsSource.DataSource = _mainVmSource;
            // 
            // _semanticKernelComponent
            // 
            _semanticKernelComponent.AssistantInstructions = "";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Location = new Point(13, 536);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1397, 252);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Todo-Item";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(_txtTodoItemText, 0, 0);
            tableLayoutPanel1.Location = new Point(7, 32);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1383, 213);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(_txtDateDue);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 155);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(151, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(433, 32);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 111);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 4;
            label4.Text = "Date due:";
            // 
            // _txtDateDue
            // 
            _txtDateDue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _txtDateDue.Location = new Point(151, 63);
            _txtDateDue.Name = "_txtDateDue";
            _txtDateDue.Size = new Size(433, 32);
            _txtDateDue.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 66);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 2;
            label1.Text = "Start date:";
            // 
            // _txtTodoItemText
            // 
            _txtTodoItemText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(_txtTodoItemText, 2);
            _txtTodoItemText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _txtTodoItemText.Location = new Point(10, 10);
            _txtTodoItemText.Margin = new Padding(10);
            _txtTodoItemText.Name = "_txtTodoItemText";
            _txtTodoItemText.PlaceholderText = "New Todo Item";
            _txtTodoItemText.Size = new Size(1363, 32);
            _txtTodoItemText.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(_txtNotes);
            panel2.Location = new Point(603, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(777, 155);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 16);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 0;
            label3.Text = "Notes:";
            // 
            // _txtNotes
            // 
            _txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _txtNotes.Location = new Point(12, 47);
            _txtNotes.Multiline = true;
            _txtNotes.Name = "_txtNotes";
            _txtNotes.Size = new Size(746, 93);
            _txtNotes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 18);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 0;
            label2.Text = "Category";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(151, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(433, 33);
            comboBox1.TabIndex = 1;
            // 
            // FrmTaskTamerMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 828);
            Controls.Add(groupBox1);
            Controls.Add(_tasksGridView);
            Controls.Add(_statusStrip);
            Controls.Add(_mainMenuStrip);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = _mainMenuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmTaskTamerMain";
            Text = "Task Tamer - .NET 9 RC1 Demo. And yes. It's WinForms.";
            _statusStrip.ResumeLayout(false);
            _statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_mainVmSource).EndInit();
            _mainMenuStrip.ResumeLayout(false);
            _mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_tasksGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)_taskVmSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_projectsSource).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip _statusStrip;
        private MenuStrip _mainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem baseDataToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripStatusLabel _lblDateTime;
        private ToolStripStatusLabel _lblCurrentUser;
        private ToolStripMenuItem prToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem testsToolStripMenuItem;
        private ToolStripMenuItem _demoInvokeAsyncMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripStatusLabel _lblSelectedTasksProjectInfo;
        private DemoToolkit.Mvvm.WinForms.Controls.GridView _tasksGridView;
        private TaskTamer9.WinForms.Views.TaskViewItem _taskItemView;
        private BindingSource _mainVmSource;
        private BindingSource _taskVmSource;
        private ToolStripSeparator toolStripMenuItem2;
        private BindingSource _projectsSource;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem orderByDueDateToolStripMenuItem;
        private ToolStripMenuItem orderByLastModifiedToolStripMenuItem;
        private ToolStripMenuItem orderByStatusToolStripMenuItem;
        private ToolStripStatusLabel _lblSortOrder;
        private TaskTamer9.WinForms.Views.TaskViewItem _taskViewItem;
        private DemoToolkit.Mvvm.WinForms.AI.SemanticKernelBaseComponent _semanticKernelComponent;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox textBox1;
        private Label label4;
        private TextBox _txtDateDue;
        private Label label1;
        private TextBox _txtTodoItemText;
        private Panel panel2;
        private Label label3;
        private TextBox _txtNotes;
        private ComboBox comboBox1;
        private Label label2;
    }
}
