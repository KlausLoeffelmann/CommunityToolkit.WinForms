namespace WinFormsSkPlayGround
{
    partial class frmRetro
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
            _retroWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)_retroWebView).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            _retroWebView.AllowExternalDrop = true;
            _retroWebView.CreationProperties = null;
            _retroWebView.DefaultBackgroundColor = Color.White;
            _retroWebView.Dock = DockStyle.Fill;
            _retroWebView.Location = new Point(0, 0);
            _retroWebView.Name = "webView21";
            _retroWebView.Size = new Size(1151, 784);
            _retroWebView.TabIndex = 0;
            _retroWebView.ZoomFactor = 1D;
            // 
            // frmRetro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 784);
            Controls.Add(_retroWebView);
            Name = "frmRetro";
            Text = " ♫♪.ılılıll|̲̅̅●̲̅̅|̲̅̅=̲̅̅|̲̅̅●̲̅̅|llılılı.♫♪   >>>  80s R E T R O -- M A C H I N E  <<<   ♫♪.ılılıll|̲̅̅●̲̅̅|̲̅̅=̲̅̅|̲̅̅●̲̅̅|llılılı.♫♪";
            ((System.ComponentModel.ISupportInitialize)_retroWebView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 _retroWebView;
    }
}