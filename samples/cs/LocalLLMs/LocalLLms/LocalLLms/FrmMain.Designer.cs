namespace LocalLLms
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
            _btnConnectLocal = new Button();
            _txtOutput = new TextBox();
            SuspendLayout();
            // 
            // _btnConnectLocal
            // 
            _btnConnectLocal.Location = new Point(287, 12);
            _btnConnectLocal.Name = "_btnConnectLocal";
            _btnConnectLocal.Size = new Size(238, 56);
            _btnConnectLocal.TabIndex = 0;
            _btnConnectLocal.Text = "Connect to loca Phi3";
            _btnConnectLocal.UseVisualStyleBackColor = true;
            _btnConnectLocal.Click += BtnConnectLocal_Click;
            // 
            // _txtOutput
            // 
            _txtOutput.Location = new Point(12, 95);
            _txtOutput.Multiline = true;
            _txtOutput.Name = "_txtOutput";
            _txtOutput.Size = new Size(776, 343);
            _txtOutput.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_txtOutput);
            Controls.Add(_btnConnectLocal);
            Name = "FrmMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button _btnConnectLocal;
        private TextBox _txtOutput;
    }
}
