namespace WinFormsSkPlayGround.Views
{
    partial class AIPlayGroundView
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            _conversationView = new WinForms.ControlConcepts.ConversationView();
            panel1 = new Panel();
            label6 = new Label();
            trackBar5 = new TrackBar();
            label5 = new Label();
            _frequencyPenaltySlider = new TrackBar();
            label4 = new Label();
            trackBar3 = new TrackBar();
            label3 = new Label();
            trackBar2 = new TrackBar();
            label2 = new Label();
            trackBar1 = new TrackBar();
            label1 = new Label();
            _sldTemperature = new TrackBar();
            _promptControl = new SemanticKernelDemo.Controls.AsyncPromptControl();
            _semanticKernelConversation = new SemanticKernelDemo.SemanticKernel.SemanticKernelComponent();
            _toolTip = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_frequencyPenaltySlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_sldTemperature).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(_promptControl, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(_conversationView, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1335, 683);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // _conversationView
            // 
            _conversationView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _conversationView.HostPage = "wwwroot/index.html";
            _conversationView.Location = new Point(3, 3);
            _conversationView.Name = "_conversationView";
            _conversationView.Size = new Size(661, 335);
            _conversationView.StartPath = "/";
            _conversationView.TabIndex = 2;
            _conversationView.Text = "markdownRenderer1";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(trackBar5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(_frequencyPenaltySlider);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(trackBar3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(trackBar2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(_sldTemperature);
            panel1.Location = new Point(670, 3);
            panel1.Name = "panel1";
            tableLayoutPanel1.SetRowSpan(panel1, 2);
            panel1.Size = new Size(662, 677);
            panel1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 558);
            label6.Name = "label6";
            label6.Size = new Size(142, 25);
            label6.TabIndex = 11;
            label6.Text = "Presence Penalty";
            // 
            // trackBar5
            // 
            trackBar5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBar5.Location = new Point(22, 594);
            trackBar5.Name = "trackBar5";
            trackBar5.Size = new Size(845, 69);
            trackBar5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 449);
            label5.Name = "label5";
            label5.Size = new Size(154, 25);
            label5.TabIndex = 9;
            label5.Text = "Frequency Penalty";
            // 
            // _frequencyPenaltySlider
            // 
            _frequencyPenaltySlider.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _frequencyPenaltySlider.BackColor = SystemColors.ControlDarkDark;
            _frequencyPenaltySlider.LargeChange = 10;
            _frequencyPenaltySlider.Location = new Point(22, 485);
            _frequencyPenaltySlider.Maximum = 20;
            _frequencyPenaltySlider.Minimum = -20;
            _frequencyPenaltySlider.Name = "_frequencyPenaltySlider";
            _frequencyPenaltySlider.Size = new Size(845, 69);
            _frequencyPenaltySlider.TabIndex = 8;
            _frequencyPenaltySlider.TickFrequency = 10;
            _frequencyPenaltySlider.TickStyle = TickStyle.Both;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 340);
            label4.Name = "label4";
            label4.Size = new Size(216, 25);
            label4.TabIndex = 7;
            label4.Text = "Top-p (Nucleus Sampling)";
            // 
            // trackBar3
            // 
            trackBar3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBar3.Location = new Point(22, 376);
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(845, 69);
            trackBar3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 231);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 5;
            label3.Text = "Top-k Sampling:";
            // 
            // trackBar2
            // 
            trackBar2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBar2.Location = new Point(22, 267);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(845, 69);
            trackBar2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 122);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 3;
            label2.Text = "Response Length";
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBar1.Location = new Point(22, 158);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(845, 69);
            trackBar1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 1;
            label1.Text = "Temperature (Creativity)";
            // 
            // _sldTemperature
            // 
            _sldTemperature.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _sldTemperature.Location = new Point(22, 49);
            _sldTemperature.Name = "_sldTemperature";
            _sldTemperature.Size = new Size(845, 69);
            _sldTemperature.TabIndex = 0;
            // 
            // _promptControl
            // 
            _promptControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _promptControl.Location = new Point(3, 344);
            _promptControl.Multiline = true;
            _promptControl.Name = "_promptControl";
            _promptControl.Size = new Size(661, 336);
            _promptControl.TabIndex = 4;
            _promptControl.VisualStylesMode = VisualStylesMode.Latest;
            // 
            // _semanticKernelConversation
            // 
            _semanticKernelConversation.AssistantInstructions = "";
            _semanticKernelConversation.Temperature = 1D;
            _semanticKernelConversation.TopP = 1D;
            // 
            // AIPlayGroundView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "AIPlayGroundView";
            Size = new Size(1335, 683);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar5).EndInit();
            ((System.ComponentModel.ISupportInitialize)_frequencyPenaltySlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_sldTemperature).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private WinForms.ControlConcepts.ConversationView _conversationView;
        private Panel panel1;
        private Label label6;
        private TrackBar trackBar5;
        private Label label5;
        private TrackBar _frequencyPenaltySlider;
        private Label label4;
        private TrackBar trackBar3;
        private Label label3;
        private TrackBar trackBar2;
        private Label label2;
        private TrackBar trackBar1;
        private Label label1;
        private TrackBar _sldTemperature;
        private SemanticKernelDemo.Controls.AsyncPromptControl _promptControl;
        private SemanticKernelDemo.SemanticKernel.SemanticKernelComponent _semanticKernelConversation;
        private ToolTip _toolTip;
    }
}
