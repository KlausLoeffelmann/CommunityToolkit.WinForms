using WinFormsSkPlayGround.Controls;

namespace WinFormsSkPlayGround
{
    partial class FrmTestForm
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
            floatingPointTrackBar1 = new FloatingPointTrackBar();
            _lblValue = new Label();
            ((System.ComponentModel.ISupportInitialize)floatingPointTrackBar1).BeginInit();
            SuspendLayout();
            // 
            // floatingPointTrackBar1
            // 
            floatingPointTrackBar1.LargeChange = 0.25F;
            floatingPointTrackBar1.Location = new Point(24, 29);
            floatingPointTrackBar1.Minimum = 0F;
            floatingPointTrackBar1.Name = "floatingPointTrackBar1";
            floatingPointTrackBar1.Size = new Size(454, 69);
            floatingPointTrackBar1.SmallChange = 0.1F;
            floatingPointTrackBar1.TabIndex = 0;
            floatingPointTrackBar1.TickFrequency = 0.2F;
            floatingPointTrackBar1.Scroll += floatingPointTrackBar1_Scroll;
            // 
            // _lblValue
            // 
            _lblValue.AutoSize = true;
            _lblValue.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _lblValue.Location = new Point(529, 48);
            _lblValue.Name = "_lblValue";
            _lblValue.Size = new Size(91, 38);
            _lblValue.TabIndex = 1;
            _lblValue.Text = "label1";
            // 
            // FrmTestForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 502);
            Controls.Add(_lblValue);
            Controls.Add(floatingPointTrackBar1);
            Name = "FrmTestForm";
            Text = "FrmTestForm";
            ((System.ComponentModel.ISupportInitialize)floatingPointTrackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FloatingPointTrackBar floatingPointTrackBar1;
        private Label _lblValue;
    }
}