namespace Chatty.Views
{
    partial class FrmOptions
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
            _chkArchiveChats = new CheckBox();
            _grpChatSettings = new GroupBox();
            fluentDecoratorPanel1 = new CommunityToolkit.WinForms.FluentUI.FluentDecoratorPanel();
            _txtAppDataPath = new TextBox();
            _btnPickPath = new Button();
            _btnOK = new Button();
            _btnCancel = new Button();
            _chkCopyLastAnswerToClipboard = new CheckBox();
            _grpChatSettings.SuspendLayout();
            fluentDecoratorPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // _chkArchiveChats
            // 
            _chkArchiveChats.AutoSize = true;
            _chkArchiveChats.Location = new Point(8, 38);
            _chkArchiveChats.Margin = new Padding(4);
            _chkArchiveChats.Name = "_chkArchiveChats";
            _chkArchiveChats.Size = new Size(261, 34);
            _chkArchiveChats.TabIndex = 0;
            _chkArchiveChats.Text = "Archive chats to folder:";
            _chkArchiveChats.UseVisualStyleBackColor = true;
            _chkArchiveChats.CheckedChanged += ChkArchiveChats_CheckedChanged;
            // 
            // _grpChatSettings
            // 
            _grpChatSettings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _grpChatSettings.Controls.Add(_chkCopyLastAnswerToClipboard);
            _grpChatSettings.Controls.Add(fluentDecoratorPanel1);
            _grpChatSettings.Controls.Add(_chkArchiveChats);
            _grpChatSettings.Location = new Point(13, 13);
            _grpChatSettings.Margin = new Padding(4);
            _grpChatSettings.Name = "_grpChatSettings";
            _grpChatSettings.Padding = new Padding(4);
            _grpChatSettings.Size = new Size(634, 208);
            _grpChatSettings.TabIndex = 1;
            _grpChatSettings.TabStop = false;
            _grpChatSettings.Text = "Chat settings:";
            // 
            // fluentDecoratorPanel1
            // 
            fluentDecoratorPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fluentDecoratorPanel1.BorderThickness = 1;
            fluentDecoratorPanel1.Controls.Add(_txtAppDataPath);
            fluentDecoratorPanel1.Controls.Add(_btnPickPath);
            fluentDecoratorPanel1.Location = new Point(27, 76);
            fluentDecoratorPanel1.Margin = new Padding(4);
            fluentDecoratorPanel1.Name = "fluentDecoratorPanel1";
            fluentDecoratorPanel1.Padding = new Padding(6);
            fluentDecoratorPanel1.Size = new Size(589, 38);
            fluentDecoratorPanel1.TabIndex = 1;
            // 
            // _txtAppDataPath
            // 
            _txtAppDataPath.BorderStyle = BorderStyle.None;
            _txtAppDataPath.Location = new Point(7, 5);
            _txtAppDataPath.Margin = new Padding(4);
            _txtAppDataPath.Name = "_txtAppDataPath";
            _txtAppDataPath.Size = new Size(535, 29);
            _txtAppDataPath.TabIndex = 0;
            // 
            // _btnPickPath
            // 
            _btnPickPath.FlatStyle = FlatStyle.Flat;
            _btnPickPath.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _btnPickPath.Location = new Point(552, 5);
            _btnPickPath.Margin = new Padding(4);
            _btnPickPath.Name = "_btnPickPath";
            _btnPickPath.Size = new Size(30, 29);
            _btnPickPath.TabIndex = 2;
            _btnPickPath.Text = "...";
            _btnPickPath.UseVisualStyleBackColor = true;
            _btnPickPath.Click += BtnPickPath_Click;
            // 
            // _btnOK
            // 
            _btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnOK.DialogResult = DialogResult.OK;
            _btnOK.FlatStyle = FlatStyle.Flat;
            _btnOK.Location = new Point(670, 23);
            _btnOK.Name = "_btnOK";
            _btnOK.Size = new Size(140, 46);
            _btnOK.TabIndex = 2;
            _btnOK.Text = "OK";
            _btnOK.UseVisualStyleBackColor = true;
            // 
            // _btnCancel
            // 
            _btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnCancel.DialogResult = DialogResult.Cancel;
            _btnCancel.FlatStyle = FlatStyle.Flat;
            _btnCancel.Location = new Point(670, 83);
            _btnCancel.Name = "_btnCancel";
            _btnCancel.Size = new Size(140, 46);
            _btnCancel.TabIndex = 3;
            _btnCancel.Text = "Cancel";
            _btnCancel.UseVisualStyleBackColor = true;
            // 
            // _chkCopyLastAnswerToClipboard
            // 
            _chkCopyLastAnswerToClipboard.AutoSize = true;
            _chkCopyLastAnswerToClipboard.Location = new Point(8, 157);
            _chkCopyLastAnswerToClipboard.Margin = new Padding(4);
            _chkCopyLastAnswerToClipboard.Name = "_chkCopyLastAnswerToClipboard";
            _chkCopyLastAnswerToClipboard.Size = new Size(325, 34);
            _chkCopyLastAnswerToClipboard.TabIndex = 2;
            _chkCopyLastAnswerToClipboard.Text = "Copy last answer to clipboard";
            _chkCopyLastAnswerToClipboard.UseVisualStyleBackColor = true;
            // 
            // FrmOptions
            // 
            AcceptButton = _btnOK;
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = _btnCancel;
            ClientSize = new Size(822, 237);
            Controls.Add(_btnCancel);
            Controls.Add(_btnOK);
            Controls.Add(_grpChatSettings);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmOptions";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Options";
            Load += FrmOptions_Load;
            _grpChatSettings.ResumeLayout(false);
            _grpChatSettings.PerformLayout();
            fluentDecoratorPanel1.ResumeLayout(false);
            fluentDecoratorPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox _chkArchiveChats;
        private GroupBox _grpChatSettings;
        private CommunityToolkit.WinForms.FluentUI.FluentDecoratorPanel fluentDecoratorPanel1;
        private TextBox _txtAppDataPath;
        private Button _btnPickPath;
        private Button _btnOK;
        private Button _btnCancel;
        private CheckBox _chkCopyLastAnswerToClipboard;
    }
}