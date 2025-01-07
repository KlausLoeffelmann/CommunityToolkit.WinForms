using CommunityToolkit.WinForms.AI;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AIPlayGroundView));
            _mainLayoutPanel = new TableLayoutPanel();
            _conversationView = new WinForms.ControlConcepts.ConversationView();
            _promptControl = new SemanticKernelDemo.Controls.AsyncPromptControl();
            panel1 = new Panel();
            _btnClearHistory = new Button();
            _cmbPersonalities = new ComboBox();
            _lblChatBotPersonality = new Label();
            editFloatingPointSlider1 = new WinFormsSkPlayGround.Controls.EditFloatingPointSlider();
            label1 = new Label();
            _semanticKernelCommunicator = new SemanticKernelComponent();
            _toolTip = new ToolTip(components);
            _controlsLayoutPanel = new TableLayoutPanel();
            _mainLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            _controlsLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // _mainLayoutPanel
            // 
            _mainLayoutPanel.ColumnCount = 2;
            _mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            _mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            _mainLayoutPanel.Controls.Add(_conversationView, 0, 0);
            _mainLayoutPanel.Controls.Add(_promptControl, 0, 1);
            _mainLayoutPanel.Controls.Add(panel1, 1, 0);
            _mainLayoutPanel.Dock = DockStyle.Fill;
            _mainLayoutPanel.Location = new Point(0, 0);
            _mainLayoutPanel.Margin = new Padding(4);
            _mainLayoutPanel.Name = "_mainLayoutPanel";
            _mainLayoutPanel.RowCount = 2;
            _mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            _mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            _mainLayoutPanel.Size = new Size(1357, 846);
            _mainLayoutPanel.TabIndex = 0;
            // 
            // _conversationView
            // 
            _conversationView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _conversationView.HostPage = "wwwroot/index.html";
            _conversationView.Location = new Point(4, 4);
            _conversationView.Margin = new Padding(4);
            _conversationView.Name = "_conversationView";
            _conversationView.Padding = new Padding(5);
            _conversationView.Size = new Size(896, 626);
            _conversationView.TabIndex = 5;
            _conversationView.Text = "markdownRenderer1";
            // 
            // _promptControl
            // 
            _promptControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _promptControl.Location = new Point(4, 638);
            _promptControl.Margin = new Padding(4);
            _promptControl.Multiline = true;
            _promptControl.Name = "_promptControl";
            _promptControl.Size = new Size(896, 204);
            _promptControl.TabIndex = 4;
            _promptControl.AsyncSendPrompt += PromptControl_AsyncSendPrompt;
            _promptControl.NewPromptSuggestionRequest += PromptControl_NewPromptSuggestionRequest;
            _promptControl.PreviousPromptRequest += PromptControl_NewPromptSuggestionRequest;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(_controlsLayoutPanel);
            panel1.Location = new Point(908, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            _mainLayoutPanel.SetRowSpan(panel1, 2);
            panel1.Size = new Size(445, 838);
            panel1.TabIndex = 3;
            // 
            // _btnClearHistory
            // 
            _btnClearHistory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _btnClearHistory.FlatStyle = FlatStyle.System;
            _btnClearHistory.Location = new Point(20, 753);
            _btnClearHistory.Margin = new Padding(20);
            _btnClearHistory.Name = "_btnClearHistory";
            _btnClearHistory.Size = new Size(405, 65);
            _btnClearHistory.TabIndex = 5;
            _btnClearHistory.Text = "Clear History";
            _btnClearHistory.UseVisualStyleBackColor = true;
            _btnClearHistory.Click += BtnClearHistory_Click;
            // 
            // _cmbPersonalities
            // 
            _cmbPersonalities.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _cmbPersonalities.FormattingEnabled = true;
            _cmbPersonalities.Location = new Point(5, 51);
            _cmbPersonalities.Margin = new Padding(5);
            _cmbPersonalities.Name = "_cmbPersonalities";
            _cmbPersonalities.Size = new Size(435, 44);
            _cmbPersonalities.TabIndex = 4;
            // 
            // _lblChatBotPersonality
            // 
            _lblChatBotPersonality.AutoSize = true;
            _lblChatBotPersonality.Location = new Point(3, 10);
            _lblChatBotPersonality.Margin = new Padding(3, 10, 3, 0);
            _lblChatBotPersonality.Name = "_lblChatBotPersonality";
            _lblChatBotPersonality.Size = new Size(249, 36);
            _lblChatBotPersonality.TabIndex = 3;
            _lblChatBotPersonality.Text = "Chat-Bot Personality";
            // 
            // editFloatingPointSlider1
            // 
            editFloatingPointSlider1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editFloatingPointSlider1.Location = new Point(6, 152);
            editFloatingPointSlider1.Margin = new Padding(6);
            editFloatingPointSlider1.Maximum = 2F;
            editFloatingPointSlider1.Name = "editFloatingPointSlider1";
            editFloatingPointSlider1.Size = new Size(433, 55);
            editFloatingPointSlider1.TabIndex = 2;
            editFloatingPointSlider1.Text = "_sliderTemperature";
            editFloatingPointSlider1.Value = 0.3F;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(4, 110);
            label1.Margin = new Padding(4, 10, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(290, 36);
            label1.TabIndex = 1;
            label1.Text = "Temperature (Creativity)";
            _toolTip.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // _semanticKernelCommunicator
            // 
            _semanticKernelCommunicator.Temperature = 1D;
            _semanticKernelCommunicator.TopP = 1D;
            // 
            // _controlsLayoutPanel
            // 
            _controlsLayoutPanel.ColumnCount = 1;
            _controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            _controlsLayoutPanel.Controls.Add(_cmbPersonalities, 0, 1);
            _controlsLayoutPanel.Controls.Add(_btnClearHistory, 0, 4);
            _controlsLayoutPanel.Controls.Add(_lblChatBotPersonality, 0, 0);
            _controlsLayoutPanel.Controls.Add(label1, 0, 2);
            _controlsLayoutPanel.Controls.Add(editFloatingPointSlider1, 0, 3);
            _controlsLayoutPanel.Dock = DockStyle.Fill;
            _controlsLayoutPanel.Location = new Point(0, 0);
            _controlsLayoutPanel.Name = "_controlsLayoutPanel";
            _controlsLayoutPanel.RowCount = 5;
            _controlsLayoutPanel.RowStyles.Add(new RowStyle());
            _controlsLayoutPanel.RowStyles.Add(new RowStyle());
            _controlsLayoutPanel.RowStyles.Add(new RowStyle());
            _controlsLayoutPanel.RowStyles.Add(new RowStyle());
            _controlsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            _controlsLayoutPanel.Size = new Size(445, 838);
            _controlsLayoutPanel.TabIndex = 6;
            // 
            // AIPlayGroundView
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_mainLayoutPanel);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AIPlayGroundView";
            Size = new Size(1357, 846);
            _mainLayoutPanel.ResumeLayout(false);
            _mainLayoutPanel.PerformLayout();
            panel1.ResumeLayout(false);
            _controlsLayoutPanel.ResumeLayout(false);
            _controlsLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel _mainLayoutPanel;
        private Panel panel1;
        private Label label1;
        private SemanticKernelDemo.Controls.AsyncPromptControl _promptControl;
        private SemanticKernelComponent _semanticKernelCommunicator;
        private ToolTip _toolTip;
        private Controls.EditFloatingPointSlider editFloatingPointSlider1;
        private WinForms.ControlConcepts.ConversationView _conversationView;
        private ComboBox _cmbPersonalities;
        private Label _lblChatBotPersonality;
        private Button _btnClearHistory;
        private TableLayoutPanel _controlsLayoutPanel;
    }
}
