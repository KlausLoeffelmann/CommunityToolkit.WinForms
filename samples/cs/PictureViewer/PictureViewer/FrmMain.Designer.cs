namespace PictureViewer
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
            fluentDecoratorPanel1 = new CommunityToolkit.WinForms.FluentUI.FluentDecoratorPanel();
            _txtLabel = new Label();
            _btnSelectImageBasePath = new Button();
            _imageGridView = new CommunityToolkit.WinForms.FluentUI.GridView();
            _statusStrip = new StatusStrip();
            _tslStatus = new ToolStripStatusLabel();
            fluentDecoratorPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_imageGridView).BeginInit();
            _statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // fluentDecoratorPanel1
            // 
            fluentDecoratorPanel1.BorderThickness = 1;
            fluentDecoratorPanel1.ControlPadding = 20;
            fluentDecoratorPanel1.Controls.Add(_txtLabel);
            fluentDecoratorPanel1.Controls.Add(_btnSelectImageBasePath);
            fluentDecoratorPanel1.Dock = DockStyle.Top;
            fluentDecoratorPanel1.Location = new Point(10, 10);
            fluentDecoratorPanel1.Margin = new Padding(4);
            fluentDecoratorPanel1.Name = "fluentDecoratorPanel1";
            fluentDecoratorPanel1.Padding = new Padding(10);
            fluentDecoratorPanel1.Size = new Size(980, 68);
            fluentDecoratorPanel1.TabIndex = 0;
            // 
            // _txtLabel
            // 
            _txtLabel.Location = new Point(11, 11);
            _txtLabel.Name = "_txtLabel";
            _txtLabel.Size = new Size(884, 47);
            _txtLabel.TabIndex = 1;
            _txtLabel.Text = "C:\\";
            _txtLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _btnSelectImageBasePath
            // 
            _btnSelectImageBasePath.Location = new Point(915, 11);
            _btnSelectImageBasePath.Margin = new Padding(3, 3, 20, 3);
            _btnSelectImageBasePath.Name = "_btnSelectImageBasePath";
            _btnSelectImageBasePath.Size = new Size(54, 47);
            _btnSelectImageBasePath.TabIndex = 0;
            _btnSelectImageBasePath.Text = "...";
            _btnSelectImageBasePath.UseVisualStyleBackColor = true;
            // 
            // _imageGridView
            // 
            _imageGridView.AllowUserToAddRows = false;
            _imageGridView.AllowUserToDeleteRows = false;
            _imageGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _imageGridView.GridViewItemTemplate = null;
            _imageGridView.Location = new Point(10, 88);
            _imageGridView.Margin = new Padding(4);
            _imageGridView.Name = "_imageGridView";
            _imageGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _imageGridView.Size = new Size(980, 423);
            _imageGridView.TabIndex = 1;
            _imageGridView.VirtualMode = true;
            // 
            // _statusStrip
            // 
            _statusStrip.ImageScalingSize = new Size(20, 20);
            _statusStrip.Items.AddRange(new ToolStripItem[] { _tslStatus });
            _statusStrip.Location = new Point(10, 528);
            _statusStrip.Name = "_statusStrip";
            _statusStrip.Padding = new Padding(1, 0, 18, 0);
            _statusStrip.Size = new Size(980, 24);
            _statusStrip.TabIndex = 2;
            _statusStrip.Text = "statusStrip1";
            // 
            // _tslStatus
            // 
            _tslStatus.Name = "_tslStatus";
            _tslStatus.Size = new Size(0, 18);
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(_statusStrip);
            Controls.Add(_imageGridView);
            Controls.Add(fluentDecoratorPanel1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmMain";
            Padding = new Padding(10);
            Text = "WinForms .NET 9 Picture Viewer";
            fluentDecoratorPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_imageGridView).EndInit();
            _statusStrip.ResumeLayout(false);
            _statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CommunityToolkit.WinForms.FluentUI.FluentDecoratorPanel fluentDecoratorPanel1;
        private Label _txtLabel;
        private Button _btnSelectImageBasePath;
        private CommunityToolkit.WinForms.FluentUI.GridView _imageGridView;
        private StatusStrip _statusStrip;
        private ToolStripStatusLabel _tslStatus;
    }
}
