using SemanticKernelDemo.Controls;

namespace SemanticKernelDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            _promptControl = new PromptControl();
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
            _semanticKernelConversation = new SemanticKernel.SemanticKernelConversation();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            browserDeveloperToolsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            sOLONLetsCallBackThe80sToolStripMenuItem = new ToolStripMenuItem();
            statusStrip2 = new StatusStrip();
            _toolTip = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_frequencyPenaltySlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_sldTemperature).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // _promptControl
            // 
            _promptControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _promptControl.Location = new Point(3, 673);
            _promptControl.Multiline = true;
            _promptControl.Name = "_promptControl";
            _promptControl.Size = new Size(900, 97);
            _promptControl.TabIndex = 0;
            _promptControl.VisualStylesMode = VisualStylesMode.Latest;
            _promptControl.SendPrompt += PromptControl_SendPrompt;
            _promptControl.NewPromptSuggestionRequest += PromptControl_NewPromptSuggestionRequest;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(_conversationView, 0, 0);
            tableLayoutPanel1.Controls.Add(_promptControl, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 38);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1359, 773);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // _conversationView
            // 
            _conversationView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _conversationView.HostPage = "wwwroot/index.html";
            _conversationView.Location = new Point(3, 3);
            _conversationView.Name = "_conversationView";
            _conversationView.Size = new Size(900, 664);
            _conversationView.StartPath = "/";
            _conversationView.TabIndex = 1;
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
            panel1.Location = new Point(909, 3);
            panel1.Name = "panel1";
            tableLayoutPanel1.SetRowSpan(panel1, 2);
            panel1.Size = new Size(447, 767);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 558);
            label6.Name = "label6";
            label6.Size = new Size(193, 32);
            label6.TabIndex = 11;
            label6.Text = "Presence Penalty";
            // 
            // trackBar5
            // 
            trackBar5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBar5.Location = new Point(22, 594);
            trackBar5.Name = "trackBar5";
            trackBar5.Size = new Size(407, 69);
            trackBar5.TabIndex = 10;
            _toolTip.SetToolTip(trackBar5, resources.GetString("trackBar5.ToolTip"));
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 449);
            label5.Name = "label5";
            label5.Size = new Size(209, 32);
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
            _frequencyPenaltySlider.Size = new Size(407, 69);
            _frequencyPenaltySlider.TabIndex = 8;
            _frequencyPenaltySlider.TickFrequency = 10;
            _frequencyPenaltySlider.TickStyle = TickStyle.Both;
            _toolTip.SetToolTip(_frequencyPenaltySlider, "Modifies a penalty applied to words that appear more frequently in the conversation. Increasing this value discourages repetition, making the dialogue more dynamic by promoting diverse word usage.");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 340);
            label4.Name = "label4";
            label4.Size = new Size(291, 32);
            label4.TabIndex = 7;
            label4.Text = "Top-p (Nucleus Sampling)";
            // 
            // trackBar3
            // 
            trackBar3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBar3.Location = new Point(22, 376);
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(407, 69);
            trackBar3.TabIndex = 6;
            _toolTip.SetToolTip(trackBar3, resources.GetString("trackBar3.ToolTip"));
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 231);
            label3.Name = "label3";
            label3.Size = new Size(187, 32);
            label3.TabIndex = 5;
            label3.Text = "Top-k Sampling:";
            // 
            // trackBar2
            // 
            trackBar2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBar2.Location = new Point(22, 267);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(407, 69);
            trackBar2.TabIndex = 4;
            _toolTip.SetToolTip(trackBar2, resources.GetString("trackBar2.ToolTip"));
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 122);
            label2.Name = "label2";
            label2.Size = new Size(196, 32);
            label2.TabIndex = 3;
            label2.Text = "Response Length";
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trackBar1.Location = new Point(22, 158);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(407, 69);
            trackBar1.TabIndex = 2;
            _toolTip.SetToolTip(trackBar1, "Adjusts the maximum length of the AI’s response. Shorter values result in concise, to-the-point answers, while longer values allow for more detailed explanations or elaborate conversations.");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(270, 32);
            label1.TabIndex = 1;
            label1.Text = "Temperature (Creativity)";
            // 
            // _sldTemperature
            // 
            _sldTemperature.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _sldTemperature.Location = new Point(22, 49);
            _sldTemperature.Name = "_sldTemperature";
            _sldTemperature.Size = new Size(407, 69);
            _sldTemperature.TabIndex = 0;
            _toolTip.SetToolTip(_sldTemperature, resources.GetString("_sldTemperature.ToolTip"));
            // 
            // _semanticKernelConversation
            // 
            _semanticKernelConversation.AssistantInstructions = "";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1359, 38);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(68, 34);
            fileToolStripMenuItem.Text = " &File";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(157, 38);
            quitToolStripMenuItem.Text = "Quit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { browserDeveloperToolsToolStripMenuItem, toolStripMenuItem1, sOLONLetsCallBackThe80sToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(76, 34);
            viewToolStripMenuItem.Text = "View";
            // 
            // browserDeveloperToolsToolStripMenuItem
            // 
            browserDeveloperToolsToolStripMenuItem.Name = "browserDeveloperToolsToolStripMenuItem";
            browserDeveloperToolsToolStripMenuItem.Size = new Size(442, 38);
            browserDeveloperToolsToolStripMenuItem.Text = "Browser Developer Tools...";
            browserDeveloperToolsToolStripMenuItem.Click += BrowserDeveloperToolsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(439, 6);
            // 
            // sOLONLetsCallBackThe80sToolStripMenuItem
            // 
            sOLONLetsCallBackThe80sToolStripMenuItem.Name = "sOLONLetsCallBackThe80sToolStripMenuItem";
            sOLONLetsCallBackThe80sToolStripMenuItem.Size = new Size(442, 38);
            sOLONLetsCallBackThe80sToolStripMenuItem.Text = "SOLON - Let's call back the 80s! ...";
            sOLONLetsCallBackThe80sToolStripMenuItem.Click += Solon_LetsCallBackThe80sToolStripMenuItem_Click;
            // 
            // statusStrip2
            // 
            statusStrip2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip2.ImageScalingSize = new Size(24, 24);
            statusStrip2.Location = new Point(0, 811);
            statusStrip2.Name = "statusStrip2";
            statusStrip2.Size = new Size(1359, 22);
            statusStrip2.TabIndex = 3;
            statusStrip2.Text = "statusStrip2";
            // 
            // _toolTip
            // 
            _toolTip.Draw += _toolTip_Draw;
            _toolTip.Popup += _toolTip_Popup;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 833);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinForms AI Playground";
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PromptControl _promptControl;
        private TableLayoutPanel tableLayoutPanel1;
        private WinForms.ControlConcepts.ConversationView _conversationView;
        private Panel panel1;
        private SemanticKernel.SemanticKernelConversation _semanticKernelConversation;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private StatusStrip statusStrip2;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem browserDeveloperToolsToolStripMenuItem;
        private Label label1;
        private TrackBar _sldTemperature;
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
        private ToolTip _toolTip;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem sOLONLetsCallBackThe80sToolStripMenuItem;
    }
}
