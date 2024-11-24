namespace PictureViewer;

partial class FrmMain : System.Windows.Forms.Form
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
        _imageGridView = new CommunityToolkit.WinForms.FluentUI.GridView();
        _statusStrip = new StatusStrip();
        _tslStatus = new ToolStripStatusLabel();
        _tslBasePath = new ToolStripStatusLabel();
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        setImagePathToolStripMenuItem = new ToolStripMenuItem();
        toolStripMenuItem1 = new ToolStripSeparator();
        _tsmQuit = new ToolStripMenuItem();
        filterToolStripMenuItem = new ToolStripMenuItem();
        onlyHeicImagesToolStripMenuItem = new ToolStripMenuItem();
        onlyNikonImagesToolStripMenuItem = new ToolStripMenuItem();
        _tslCurrentImageItem = new ToolStripStatusLabel();
        ((System.ComponentModel.ISupportInitialize)_imageGridView).BeginInit();
        _statusStrip.SuspendLayout();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // _imageGridView
        // 
        _imageGridView.AllowUserToAddRows = false;
        _imageGridView.AllowUserToDeleteRows = false;
        _imageGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _imageGridView.GridViewItemTemplate = null;
        _imageGridView.Location = new Point(10, 61);
        _imageGridView.Margin = new Padding(4);
        _imageGridView.Name = "_imageGridView";
        _imageGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        _imageGridView.Size = new Size(980, 450);
        _imageGridView.TabIndex = 1;
        _imageGridView.VirtualMode = true;
        // 
        // _statusStrip
        // 
        _statusStrip.ImageScalingSize = new Size(20, 20);
        _statusStrip.Items.AddRange(new ToolStripItem[] { _tslStatus, _tslBasePath, _tslCurrentImageItem });
        _statusStrip.Location = new Point(10, 526);
        _statusStrip.Name = "_statusStrip";
        _statusStrip.Padding = new Padding(1, 0, 18, 0);
        _statusStrip.Size = new Size(980, 26);
        _statusStrip.TabIndex = 2;
        _statusStrip.Text = "statusStrip1";
        // 
        // _tslStatus
        // 
        _tslStatus.Name = "_tslStatus";
        _tslStatus.Size = new Size(0, 20);
        // 
        // _tslBasePath
        // 
        _tslBasePath.Name = "_tslBasePath";
        _tslBasePath.Size = new Size(123, 20);
        _tslBasePath.Text = "Image base path:";
        // 
        // menuStrip1
        // 
        menuStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, filterToolStripMenuItem });
        menuStrip1.Location = new Point(10, 10);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(980, 33);
        menuStrip1.TabIndex = 3;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setImagePathToolStripMenuItem, toolStripMenuItem1, _tsmQuit });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(52, 29);
        fileToolStripMenuItem.Text = "File";
        // 
        // setImagePathToolStripMenuItem
        // 
        setImagePathToolStripMenuItem.Name = "setImagePathToolStripMenuItem";
        setImagePathToolStripMenuItem.Size = new Size(229, 30);
        setImagePathToolStripMenuItem.Text = "Set Image Path...";
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(226, 6);
        // 
        // _tsmQuit
        // 
        _tsmQuit.Name = "_tsmQuit";
        _tsmQuit.Size = new Size(229, 30);
        _tsmQuit.Text = "Quit";
        // 
        // filterToolStripMenuItem
        // 
        filterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { onlyHeicImagesToolStripMenuItem, onlyNikonImagesToolStripMenuItem });
        filterToolStripMenuItem.Name = "filterToolStripMenuItem";
        filterToolStripMenuItem.Size = new Size(76, 29);
        filterToolStripMenuItem.Text = "Filter...";
        // 
        // onlyHeicImagesToolStripMenuItem
        // 
        onlyHeicImagesToolStripMenuItem.Name = "onlyHeicImagesToolStripMenuItem";
        onlyHeicImagesToolStripMenuItem.Size = new Size(250, 30);
        onlyHeicImagesToolStripMenuItem.Text = "Only Heic Images";
        // 
        // onlyNikonImagesToolStripMenuItem
        // 
        onlyNikonImagesToolStripMenuItem.Name = "onlyNikonImagesToolStripMenuItem";
        onlyNikonImagesToolStripMenuItem.Size = new Size(250, 30);
        onlyNikonImagesToolStripMenuItem.Text = "Only Nikon Images";
        // 
        // _tslCurrentImageItem
        // 
        _tslCurrentImageItem.Name = "_tslCurrentImageItem";
        _tslCurrentImageItem.Size = new Size(0, 20);
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1000, 562);
        Controls.Add(_statusStrip);
        Controls.Add(menuStrip1);
        Controls.Add(_imageGridView);
        Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        MainMenuStrip = menuStrip1;
        Margin = new Padding(4);
        Name = "FrmMain";
        Padding = new Padding(10);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "WinForms .NET 9 Picture Viewer";
        ((System.ComponentModel.ISupportInitialize)_imageGridView).EndInit();
        _statusStrip.ResumeLayout(false);
        _statusStrip.PerformLayout();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private CommunityToolkit.WinForms.FluentUI.GridView _imageGridView;
    private StatusStrip _statusStrip;
    private ToolStripStatusLabel _tslStatus;
    private ToolStripStatusLabel _tslBasePath;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem setImagePathToolStripMenuItem;
    private ToolStripSeparator toolStripMenuItem1;
    private ToolStripMenuItem _tsmQuit;
    private ToolStripMenuItem filterToolStripMenuItem;
    private ToolStripMenuItem onlyHeicImagesToolStripMenuItem;
    private ToolStripMenuItem onlyNikonImagesToolStripMenuItem;
    private ToolStripStatusLabel _tslCurrentImageItem;
}
