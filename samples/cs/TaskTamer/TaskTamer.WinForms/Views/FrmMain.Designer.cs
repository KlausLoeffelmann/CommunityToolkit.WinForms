﻿using CommunityToolbox.WinForms.Mvvm.Controls;
using CommunityToolkit.WinForms.GridView;

namespace TaskTamer.WinForms
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
            components = new System.ComponentModel.Container();
            TaskTamer9.WinForms.Views.TaskViewItem taskViewItem2 = new TaskTamer9.WinForms.Views.TaskViewItem();
            _statusStrip = new StatusStrip();
            _lblSortOrder = new ToolStripStatusLabel();
            _lblSelectedTasksProjectInfo = new ToolStripStatusLabel();
            _selectedTaskVmSource = new BindingSource(components);
            _mainVmSource = new BindingSource(components);
            _lblCurrentUser = new ToolStripStatusLabel();
            _lblDateTime = new ToolStripStatusLabel();
            _mainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            _tsmFileQuit = new ToolStripMenuItem();
            baseDataToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            _tsmCategories = new ToolStripMenuItem();
            _tsmEditProjects = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            _tsmEditUsers = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            _tsmOrderByDueDate = new ToolStripMenuItem();
            _tskOrderByLastModified = new ToolStripMenuItem();
            _tsmOrderByStatus = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            _tsmToolsOptions = new ToolStripMenuItem();
            _semanticKernelComponent = new DemoToolkit.Mvvm.WinForms.AI.SemanticKernelBaseComponent();
            taskIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            projectDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            explanationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            notesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ownerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priorityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            percentDoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            externalReferenceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            _tasksGridView = new GridView();
            _tlpTodoItemDetails = new TableLayoutPanel();
            panel2 = new Panel();
            _lblPriority = new Label();
            _prioTrackbar = new TrackBar();
            label6 = new Label();
            label3 = new Label();
            _txtNotes = new TextBox();
            panel1 = new Panel();
            _bcmbCategory = new BindableComboBox();
            _lblPercentDoneValue = new Label();
            _chkDone = new CheckBox();
            label5 = new Label();
            _percentDoneSlider = new TrackBar();
            label2 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            _txtDateDue = new TextBox();
            label1 = new Label();
            _txtTodoItemText = new TextBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            fluentDecoratorPanel1 = new CommunityToolkit.WinForms.FluentUI.FluentDecoratorPanel();
            _txtNewTask = new TextBox();
            _btnNewTask = new Button();
            _tsmAsyncFormExperiments = new ToolStripMenuItem();
            _statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_selectedTaskVmSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_mainVmSource).BeginInit();
            _mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_tasksGridView).BeginInit();
            _tlpTodoItemDetails.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_prioTrackbar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_percentDoneSlider).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            fluentDecoratorPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // _statusStrip
            // 
            _statusStrip.Font = new Font("Segoe UI", 12F);
            _statusStrip.GripMargin = new Padding(5);
            _statusStrip.GripStyle = ToolStripGripStyle.Visible;
            _statusStrip.ImageScalingSize = new Size(20, 20);
            _statusStrip.Items.AddRange(new ToolStripItem[] { _lblSortOrder, _lblSelectedTasksProjectInfo, _lblCurrentUser, _lblDateTime });
            _statusStrip.Location = new Point(0, 784);
            _statusStrip.Margin = new Padding(0, 0, 3, 0);
            _statusStrip.Name = "_statusStrip";
            _statusStrip.Padding = new Padding(1, 0, 18, 0);
            _statusStrip.Size = new Size(1412, 36);
            _statusStrip.TabIndex = 4;
            _statusStrip.Text = "statusStrip1";
            // 
            // _lblSortOrder
            // 
            _lblSortOrder.BackColor = Color.DeepSkyBlue;
            _lblSortOrder.Name = "_lblSortOrder";
            _lblSortOrder.Size = new Size(98, 31);
            _lblSortOrder.Text = "#SortOrder#";
            // 
            // _lblSelectedTasksProjectInfo
            // 
            _lblSelectedTasksProjectInfo.DataBindings.Add(new Binding("Text", _selectedTaskVmSource, "Project", true));
            _lblSelectedTasksProjectInfo.Name = "_lblSelectedTasksProjectInfo";
            _lblSelectedTasksProjectInfo.Size = new Size(1082, 31);
            _lblSelectedTasksProjectInfo.Spring = true;
            _lblSelectedTasksProjectInfo.Text = "#SelectedTasksProjectSpring#";
            _lblSelectedTasksProjectInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _selectedTaskVmSource
            // 
            _selectedTaskVmSource.DataMember = "SelectedTask";
            _selectedTaskVmSource.DataSource = _mainVmSource;
            // 
            // _mainVmSource
            // 
            _mainVmSource.DataSource = typeof(ViewModels.MainViewModel);
            // 
            // _lblCurrentUser
            // 
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
            _mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, baseDataToolStripMenuItem, toolStripMenuItem3, toolsToolStripMenuItem });
            _mainMenuStrip.Location = new Point(0, 0);
            _mainMenuStrip.Name = "_mainMenuStrip";
            _mainMenuStrip.Padding = new Padding(13, 6, 6, 6);
            _mainMenuStrip.Size = new Size(1412, 37);
            _mainMenuStrip.TabIndex = 0;
            _mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportToolStripMenuItem, importToolStripMenuItem, toolStripMenuItem1, _tsmFileQuit });
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
            // _tsmFileQuit
            // 
            _tsmFileQuit.Name = "_tsmFileQuit";
            _tsmFileQuit.Size = new Size(136, 26);
            _tsmFileQuit.Text = "&Quit";
            // 
            // baseDataToolStripMenuItem
            // 
            baseDataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem4, toolStripMenuItem5, toolStripSeparator1, _tsmCategories, _tsmEditProjects, toolStripMenuItem2, _tsmEditUsers });
            baseDataToolStripMenuItem.Name = "baseDataToolStripMenuItem";
            baseDataToolStripMenuItem.Size = new Size(48, 25);
            baseDataToolStripMenuItem.Text = "Edit";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(180, 26);
            toolStripMenuItem4.Text = "Undo";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(180, 26);
            toolStripMenuItem5.Text = "Redo";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // _tsmCategories
            // 
            _tsmCategories.Name = "_tsmCategories";
            _tsmCategories.Size = new Size(180, 26);
            _tsmCategories.Text = "Categories...";
            // 
            // _tsmEditProjects
            // 
            _tsmEditProjects.Name = "_tsmEditProjects";
            _tsmEditProjects.Size = new Size(180, 26);
            _tsmEditProjects.Text = "&Projects...";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 6);
            // 
            // _tsmEditUsers
            // 
            _tsmEditUsers.Name = "_tsmEditUsers";
            _tsmEditUsers.Size = new Size(180, 26);
            _tsmEditUsers.Text = "Users...";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { _tsmOrderByDueDate, _tskOrderByLastModified, _tsmOrderByStatus });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(56, 25);
            toolStripMenuItem3.Text = "View";
            // 
            // _tsmOrderByDueDate
            // 
            _tsmOrderByDueDate.Name = "_tsmOrderByDueDate";
            _tsmOrderByDueDate.Size = new Size(240, 26);
            _tsmOrderByDueDate.Text = "Order by Due Date";
            // 
            // _tskOrderByLastModified
            // 
            _tskOrderByLastModified.Name = "_tskOrderByLastModified";
            _tskOrderByLastModified.Size = new Size(240, 26);
            _tskOrderByLastModified.Text = "Order by Last Modified";
            // 
            // _tsmOrderByStatus
            // 
            _tsmOrderByStatus.Name = "_tsmOrderByStatus";
            _tsmOrderByStatus.Size = new Size(240, 26);
            _tsmOrderByStatus.Text = "Order by Status";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _tsmAsyncFormExperiments, _tsmToolsOptions });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(57, 25);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // _tsmToolsOptions
            // 
            _tsmToolsOptions.Name = "_tsmToolsOptions";
            _tsmToolsOptions.Size = new Size(251, 26);
            _tsmToolsOptions.Text = "&Options...";
            // 
            // _semanticKernelComponent
            // 
            _semanticKernelComponent.AssistantInstructions = "";
            // 
            // taskIdDataGridViewTextBoxColumn
            // 
            taskIdDataGridViewTextBoxColumn.DataPropertyName = "TaskId";
            taskIdDataGridViewTextBoxColumn.HeaderText = "TaskId";
            taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
            taskIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projectDataGridViewTextBoxColumn
            // 
            projectDataGridViewTextBoxColumn.DataPropertyName = "Project";
            projectDataGridViewTextBoxColumn.HeaderText = "Project";
            projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            projectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // explanationDataGridViewTextBoxColumn
            // 
            explanationDataGridViewTextBoxColumn.DataPropertyName = "Explanation";
            explanationDataGridViewTextBoxColumn.HeaderText = "Explanation";
            explanationDataGridViewTextBoxColumn.Name = "explanationDataGridViewTextBoxColumn";
            explanationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            ownerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            priorityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // percentDoneDataGridViewTextBoxColumn
            // 
            percentDoneDataGridViewTextBoxColumn.DataPropertyName = "PercentDone";
            percentDoneDataGridViewTextBoxColumn.HeaderText = "PercentDone";
            percentDoneDataGridViewTextBoxColumn.Name = "percentDoneDataGridViewTextBoxColumn";
            percentDoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // externalReferenceDataGridViewTextBoxColumn
            // 
            externalReferenceDataGridViewTextBoxColumn.DataPropertyName = "ExternalReference";
            externalReferenceDataGridViewTextBoxColumn.HeaderText = "ExternalReference";
            externalReferenceDataGridViewTextBoxColumn.Name = "externalReferenceDataGridViewTextBoxColumn";
            externalReferenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // _tasksGridView
            // 
            _tasksGridView.AllowUserToAddRows = false;
            _tasksGridView.AllowUserToDeleteRows = false;
            _tasksGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _tasksGridView.BorderStyle = BorderStyle.None;
            _tasksGridView.DataBindings.Add(new Binding("SelectedItem", _mainVmSource, "SelectedTask", true, DataSourceUpdateMode.OnPropertyChanged));
            _tasksGridView.DataBindings.Add(new Binding("DataContext", _mainVmSource, "Tasks", true));
            taskViewItem2.ContentPadding = new Padding(5);
            taskViewItem2.DescriptionFont = new Font("Segoe UI", 16F, FontStyle.Bold);
            taskViewItem2.NameFont = new Font("Segoe UI", 16F, FontStyle.Bold);
            _tasksGridView.GridViewItemTemplate = taskViewItem2;
            _tasksGridView.Location = new Point(4, 60);
            _tasksGridView.Margin = new Padding(4);
            _tasksGridView.Name = "_tasksGridView";
            _tasksGridView.ReadOnly = true;
            _tasksGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _tasksGridView.Size = new Size(1404, 358);
            _tasksGridView.TabIndex = 2;
            _tasksGridView.VirtualMode = true;
            // 
            // _tlpTodoItemDetails
            // 
            _tlpTodoItemDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _tlpTodoItemDetails.ColumnCount = 2;
            _tlpTodoItemDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
            _tlpTodoItemDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _tlpTodoItemDetails.Controls.Add(panel2, 1, 1);
            _tlpTodoItemDetails.Controls.Add(panel1, 0, 1);
            _tlpTodoItemDetails.Controls.Add(_txtTodoItemText, 0, 0);
            _tlpTodoItemDetails.Location = new Point(7, 32);
            _tlpTodoItemDetails.Name = "_tlpTodoItemDetails";
            _tlpTodoItemDetails.RowCount = 2;
            _tlpTodoItemDetails.RowStyles.Add(new RowStyle());
            _tlpTodoItemDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _tlpTodoItemDetails.Size = new Size(1390, 272);
            _tlpTodoItemDetails.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(_lblPriority);
            panel2.Controls.Add(_prioTrackbar);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(_txtNotes);
            panel2.Location = new Point(603, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 214);
            panel2.TabIndex = 2;
            // 
            // _lblPriority
            // 
            _lblPriority.AutoSize = true;
            _lblPriority.DataBindings.Add(new Binding("Text", _selectedTaskVmSource, "Priority", true));
            _lblPriority.Font = new Font("Cascadia Code SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _lblPriority.Location = new Point(103, 11);
            _lblPriority.Name = "_lblPriority";
            _lblPriority.Size = new Size(56, 32);
            _lblPriority.TabIndex = 1;
            _lblPriority.Text = "---";
            // 
            // _prioTrackbar
            // 
            _prioTrackbar.DataBindings.Add(new Binding("Value", _selectedTaskVmSource, "Priority", true, DataSourceUpdateMode.OnPropertyChanged));
            _prioTrackbar.LargeChange = 1;
            _prioTrackbar.Location = new Point(175, 17);
            _prioTrackbar.Maximum = 5;
            _prioTrackbar.Name = "_prioTrackbar";
            _prioTrackbar.Size = new Size(262, 45);
            _prioTrackbar.TabIndex = 2;
            _prioTrackbar.Value = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 18);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 0;
            label6.Text = "Prio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 63);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 3;
            label3.Text = "Notes:";
            // 
            // _txtNotes
            // 
            _txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _txtNotes.DataBindings.Add(new Binding("Text", _selectedTaskVmSource, "Notes", true, DataSourceUpdateMode.OnPropertyChanged));
            _txtNotes.Location = new Point(99, 66);
            _txtNotes.Multiline = true;
            _txtNotes.Name = "_txtNotes";
            _txtNotes.Size = new Size(666, 132);
            _txtNotes.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(_bcmbCategory);
            panel1.Controls.Add(_lblPercentDoneValue);
            panel1.Controls.Add(_chkDone);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(_percentDoneSlider);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(_txtDateDue);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 214);
            panel1.TabIndex = 1;
            // 
            // _bcmbCategory
            // 
            _bcmbCategory.DataBindings.Add(new Binding("DataContext", _mainVmSource, "Categories", true));
            _bcmbCategory.DataBindings.Add(new Binding("SelectedBindingValue", _mainVmSource, "SelectedTask.Category", true));
            _bcmbCategory.FormattingEnabled = true;
            _bcmbCategory.Location = new Point(150, 14);
            _bcmbCategory.Name = "_bcmbCategory";
            _bcmbCategory.Size = new Size(434, 33);
            _bcmbCategory.TabIndex = 1;
            // 
            // _lblPercentDoneValue
            // 
            _lblPercentDoneValue.AutoSize = true;
            _lblPercentDoneValue.DataBindings.Add(new Binding("Text", _selectedTaskVmSource, "PercentDone", true, DataSourceUpdateMode.OnPropertyChanged));
            _lblPercentDoneValue.Location = new Point(149, 161);
            _lblPercentDoneValue.Name = "_lblPercentDoneValue";
            _lblPercentDoneValue.Size = new Size(62, 25);
            _lblPercentDoneValue.TabIndex = 7;
            _lblPercentDoneValue.Text = "- - -%";
            // 
            // _chkDone
            // 
            _chkDone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _chkDone.AutoSize = true;
            _chkDone.Location = new Point(560, 171);
            _chkDone.Name = "_chkDone";
            _chkDone.Size = new Size(15, 14);
            _chkDone.TabIndex = 9;
            _chkDone.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 160);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 6;
            label5.Text = "% done:";
            // 
            // _percentDoneSlider
            // 
            _percentDoneSlider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _percentDoneSlider.DataBindings.Add(new Binding("Value", _selectedTaskVmSource, "PercentDone", true, DataSourceUpdateMode.OnPropertyChanged));
            _percentDoneSlider.LargeChange = 10;
            _percentDoneSlider.Location = new Point(217, 163);
            _percentDoneSlider.Maximum = 99;
            _percentDoneSlider.Name = "_percentDoneSlider";
            _percentDoneSlider.Size = new Size(323, 45);
            _percentDoneSlider.TabIndex = 8;
            _percentDoneSlider.TickFrequency = 10;
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.DataBindings.Add(new Binding("Text", _selectedTaskVmSource, "DueDate", true, DataSourceUpdateMode.OnPropertyChanged));
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
            _txtDateDue.DataBindings.Add(new Binding("Text", _selectedTaskVmSource, "StartDate", true, DataSourceUpdateMode.OnPropertyChanged));
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
            _tlpTodoItemDetails.SetColumnSpan(_txtTodoItemText, 2);
            _txtTodoItemText.DataBindings.Add(new Binding("Text", _selectedTaskVmSource, "Explanation", true));
            _txtTodoItemText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _txtTodoItemText.Location = new Point(10, 10);
            _txtTodoItemText.Margin = new Padding(10);
            _txtTodoItemText.Name = "_txtTodoItemText";
            _txtTodoItemText.PlaceholderText = "Todo Item Text";
            _txtTodoItemText.Size = new Size(1370, 32);
            _txtTodoItemText.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(_tlpTodoItemDetails);
            groupBox1.Location = new Point(4, 426);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1404, 311);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Todo-Item";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(fluentDecoratorPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 2);
            tableLayoutPanel2.Controls.Add(_tasksGridView, 0, 1);
            tableLayoutPanel2.Location = new Point(0, 40);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1412, 741);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // fluentDecoratorPanel1
            // 
            fluentDecoratorPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fluentDecoratorPanel1.BorderThickness = 1;
            fluentDecoratorPanel1.ControlPadding = 0;
            fluentDecoratorPanel1.Controls.Add(_txtNewTask);
            fluentDecoratorPanel1.Controls.Add(_btnNewTask);
            fluentDecoratorPanel1.Location = new Point(3, 3);
            fluentDecoratorPanel1.Name = "fluentDecoratorPanel1";
            fluentDecoratorPanel1.Padding = new Padding(10);
            fluentDecoratorPanel1.Size = new Size(1406, 50);
            fluentDecoratorPanel1.TabIndex = 4;
            // 
            // _txtNewTask
            // 
            _txtNewTask.BorderStyle = BorderStyle.None;
            _txtNewTask.DataBindings.Add(new Binding("Text", _mainVmSource, "NewTaskName", true));
            _txtNewTask.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _txtNewTask.Location = new Point(11, 9);
            _txtNewTask.Name = "_txtNewTask";
            _txtNewTask.PlaceholderText = "Add new task";
            _txtNewTask.Size = new Size(1352, 32);
            _txtNewTask.TabIndex = 0;
            // 
            // _btnNewTask
            // 
            _btnNewTask.DataBindings.Add(new Binding("Command", _mainVmSource, "AddTaskCommand", true));
            _btnNewTask.Font = new Font("Segoe MDL2 Assets", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _btnNewTask.Location = new Point(1363, 9);
            _btnNewTask.Name = "_btnNewTask";
            _btnNewTask.Size = new Size(32, 32);
            _btnNewTask.TabIndex = 1;
            _btnNewTask.Text = "";
            _btnNewTask.UseVisualStyleBackColor = true;
            // 
            // _tsmAsyncFormExperiments
            // 
            _tsmAsyncFormExperiments.Name = "_tsmAsyncFormExperiments";
            _tsmAsyncFormExperiments.Size = new Size(251, 26);
            _tsmAsyncFormExperiments.Text = "Async Form Experiments";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 820);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(_statusStrip);
            Controls.Add(_mainMenuStrip);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = _mainMenuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMain";
            Text = "Task Tamer - .NET 9 RC1 Demo. And yes. It's WinForms.";
            _statusStrip.ResumeLayout(false);
            _statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_selectedTaskVmSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_mainVmSource).EndInit();
            _mainMenuStrip.ResumeLayout(false);
            _mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_tasksGridView).EndInit();
            _tlpTodoItemDetails.ResumeLayout(false);
            _tlpTodoItemDetails.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_prioTrackbar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_percentDoneSlider).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            fluentDecoratorPanel1.ResumeLayout(false);
            fluentDecoratorPanel1.PerformLayout();
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
        private ToolStripMenuItem _tsmFileQuit;
        private ToolStripMenuItem baseDataToolStripMenuItem;
        private ToolStripMenuItem _tsmEditUsers;
        private ToolStripStatusLabel _lblDateTime;
        private ToolStripStatusLabel _lblCurrentUser;
        private ToolStripMenuItem _tsmEditProjects;
        private ToolStripMenuItem _tsmCategories;
        private ToolStripMenuItem testsToolStripMenuItem;
        private ToolStripMenuItem _demoInvokeAsyncMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem _tsmToolsOptions;
        private ToolStripStatusLabel _lblSelectedTasksProjectInfo;
        private TaskTamer9.WinForms.Views.TaskViewItem _taskItemView;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem _tsmOrderByDueDate;
        private ToolStripMenuItem _tskOrderByLastModified;
        private ToolStripMenuItem _tsmOrderByStatus;
        private ToolStripStatusLabel _lblSortOrder;
        private TaskTamer9.WinForms.Views.TaskViewItem _taskViewItem;
        private DemoToolkit.Mvvm.WinForms.AI.SemanticKernelBaseComponent _semanticKernelComponent;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripSeparator toolStripSeparator1;
        private BindingSource _mainVmSource;
        private BindingSource _selectedTaskVmSource;
        private DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn explanationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn percentDoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn externalReferenceDataGridViewTextBoxColumn;
        private GridView _tasksGridView;
        private TableLayoutPanel _tlpTodoItemDetails;
        private Panel panel2;
        private Label _lblPriority;
        private TrackBar _prioTrackbar;
        private Label label6;
        private Label label3;
        private TextBox _txtNotes;
        private Panel panel1;
        private BindableComboBox _bcmbCategory;
        private Label _lblPercentDoneValue;
        private CheckBox _chkDone;
        private Label label5;
        private TrackBar _percentDoneSlider;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private TextBox _txtDateDue;
        private Label label1;
        private TextBox _txtTodoItemText;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private CommunityToolkit.WinForms.FluentUI.FluentDecoratorPanel fluentDecoratorPanel1;
        private TextBox _txtNewTask;
        private Button _btnNewTask;
        private ToolStripMenuItem _tsmAsyncFormExperiments;
    }
}