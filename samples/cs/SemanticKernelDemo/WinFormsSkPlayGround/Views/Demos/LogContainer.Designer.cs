namespace WinFormsSkPlayGround.Views.Demos
{
    partial class LogContainer
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
            _consoleControl = new CommunityToolkit.WinForms.Controls.ConsoleControl();
            SuspendLayout();
            // 
            // _consoleControl
            // 
            _consoleControl.Dock = DockStyle.Fill;
            _consoleControl.Location = new Point(0, 0);
            _consoleControl.Name = "_consoleControl";
            _consoleControl.Size = new Size(848, 702);
            _consoleControl.TabIndex = 0;
            _consoleControl.Text = "";
            // 
            // LogContainer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_consoleControl);
            Name = "LogContainer";
            Size = new Size(848, 702);
            ResumeLayout(false);
        }

        #endregion

        private CommunityToolkit.WinForms.Controls.ConsoleControl _consoleControl;
    }
}
