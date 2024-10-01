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
            _mainLayoutPanel = new TableLayoutPanel();
            _promptControl = new SemanticKernelDemo.Controls.AsyncPromptControl();
            panel1 = new Panel();
            editFloatingPointSlider1 = new Controls.EditFloatingPointSlider();
            label1 = new Label();
            _semanticKernelConversation = new SemanticKernelDemo.SemanticKernel.SemanticKernelComponent();
            _toolTip = new ToolTip(components);
            _conversationView = new WinForms.ControlConcepts.ConversationView();
            _mainLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // _mainLayoutPanel
            // 
            _mainLayoutPanel.ColumnCount = 2;
            _mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            _mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
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
            _mainLayoutPanel.Size = new Size(1264, 758);
            _mainLayoutPanel.TabIndex = 0;
            // 
            // _promptControl
            // 
            _promptControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _promptControl.Location = new Point(4, 572);
            _promptControl.Margin = new Padding(4);
            _promptControl.Multiline = true;
            _promptControl.Name = "_promptControl";
            _promptControl.Size = new Size(940, 182);
            _promptControl.TabIndex = 4;
            _promptControl.VisualStylesMode = VisualStylesMode.Latest;
            _promptControl.AsyncSendPrompt += PromptControl_AsyncSendPrompt;
            _promptControl.NewPromptSuggestionRequest += PromptControl_NewPromptSuggestionRequest;
            _promptControl.PreviousPromptRequest += PromptControl_NewPromptSuggestionRequest;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(editFloatingPointSlider1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(952, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            _mainLayoutPanel.SetRowSpan(panel1, 2);
            panel1.Size = new Size(308, 750);
            panel1.TabIndex = 3;
            // 
            // editFloatingPointSlider1
            // 
            editFloatingPointSlider1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            editFloatingPointSlider1.Location = new Point(26, 68);
            editFloatingPointSlider1.Margin = new Padding(4);
            editFloatingPointSlider1.Name = "editFloatingPointSlider1";
            editFloatingPointSlider1.Size = new Size(258, 44);
            editFloatingPointSlider1.TabIndex = 2;
            editFloatingPointSlider1.Text = "editFloatingPointSlider1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(26, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 30);
            label1.TabIndex = 1;
            label1.Text = "Temperature (Creativity)";
            // 
            // _semanticKernelConversation
            // 
            _semanticKernelConversation.AssistantInstructions = "";
            _semanticKernelConversation.Temperature = 1D;
            _semanticKernelConversation.TopP = 1D;
            // 
            // _conversationView
            // 
            _conversationView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _conversationView.HostPage = "wwwroot/index.html";
            _conversationView.Location = new Point(4, 4);
            _conversationView.Margin = new Padding(4);
            _conversationView.Name = "_conversationView";
            _conversationView.Padding = new Padding(5);
            _conversationView.Size = new Size(940, 560);
            _conversationView.StartPath = "/";
            _conversationView.TabIndex = 5;
            _conversationView.Text = "markdownRenderer1";
            // 
            // AIPlayGroundView
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_mainLayoutPanel);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AIPlayGroundView";
            Size = new Size(1264, 758);
            _mainLayoutPanel.ResumeLayout(false);
            _mainLayoutPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel _mainLayoutPanel;
        private Panel panel1;
        private Label label1;
        private SemanticKernelDemo.Controls.AsyncPromptControl _promptControl;
        private SemanticKernelDemo.SemanticKernel.SemanticKernelComponent _semanticKernelConversation;
        private ToolTip _toolTip;
        private Controls.EditFloatingPointSlider editFloatingPointSlider1;
        private WinForms.ControlConcepts.ConversationView _conversationView;
    }
}
