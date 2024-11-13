namespace PictureViewer
{
    partial class FrmDocument
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            _mainPanel = new Panel();
            _pictureBox = new PictureBox();
            viewToolStripMenuItem = new ToolStripMenuItem();
            sizeToFitToolStripMenuItem = new ToolStripMenuItem();
            sizeToolStripMenuItem = new ToolStripMenuItem();
            _statusStrip = new StatusStrip();
            menuStrip1.SuspendLayout();
            _mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_pictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(903, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(52, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(224, 30);
            closeToolStripMenuItem.Text = "Close";
            // 
            // _mainPanel
            // 
            _mainPanel.AutoScroll = true;
            _mainPanel.Controls.Add(_pictureBox);
            _mainPanel.Dock = DockStyle.Fill;
            _mainPanel.Location = new Point(0, 33);
            _mainPanel.Name = "_mainPanel";
            _mainPanel.Size = new Size(903, 713);
            _mainPanel.TabIndex = 1;
            // 
            // _pictureBox
            // 
            _pictureBox.Location = new Point(48, 48);
            _pictureBox.Name = "_pictureBox";
            _pictureBox.Size = new Size(760, 574);
            _pictureBox.TabIndex = 0;
            _pictureBox.TabStop = false;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sizeToFitToolStripMenuItem, sizeToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(63, 29);
            viewToolStripMenuItem.Text = "&View";
            // 
            // sizeToFitToolStripMenuItem
            // 
            sizeToFitToolStripMenuItem.Name = "sizeToFitToolStripMenuItem";
            sizeToFitToolStripMenuItem.Size = new Size(224, 30);
            sizeToFitToolStripMenuItem.Text = "Size to fit";
            // 
            // sizeToolStripMenuItem
            // 
            sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            sizeToolStripMenuItem.Size = new Size(224, 30);
            sizeToolStripMenuItem.Text = "100% size";
            // 
            // _statusStrip
            // 
            _statusStrip.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _statusStrip.ImageScalingSize = new Size(20, 20);
            _statusStrip.Location = new Point(0, 746);
            _statusStrip.Name = "_statusStrip";
            _statusStrip.Size = new Size(903, 22);
            _statusStrip.TabIndex = 2;
            _statusStrip.Text = "statusStrip1";
            // 
            // FrmDocument
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 768);
            Controls.Add(_mainPanel);
            Controls.Add(menuStrip1);
            Controls.Add(_statusStrip);
            MainMenuStrip = menuStrip1;
            Name = "FrmDocument";
            Text = "FrmDocument";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            _mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem sizeToFitToolStripMenuItem;
        private ToolStripMenuItem sizeToolStripMenuItem;
        private Panel _mainPanel;
        private PictureBox _pictureBox;
        private StatusStrip _statusStrip;
    }
}