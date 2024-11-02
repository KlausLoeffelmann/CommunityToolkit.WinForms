namespace WinFormsSkPlayGround.Views;

partial class LearnGermanDemo
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnGermanDemo));
        _mainLayoutPanel = new TableLayoutPanel();
        _germanTextPrompt = new SemanticKernelDemo.Controls.AsyncPromptControl();
        _lblEnterGermanText = new Label();
        _txtPhoneticEnglish = new TextBox();
        _lblPhoneticEnglish = new Label();
        _btnAsyncPhoneticTranslate = new SemanticKernelDemo.Controls.AsyncButton();
        _btnAsyncReadPhoneticEnglishOutLoud = new SemanticKernelDemo.Controls.AsyncButton();
        _skPhoneticEnglish = new SemanticKernelDemo.SemanticKernel.SemanticKernelComponent();
        _mainLayoutPanel.SuspendLayout();
        SuspendLayout();
        // 
        // _mainLayoutPanel
        // 
        _mainLayoutPanel.ColumnCount = 2;
        _mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        _mainLayoutPanel.ColumnStyles.Add(new ColumnStyle());
        _mainLayoutPanel.Controls.Add(_germanTextPrompt, 0, 1);
        _mainLayoutPanel.Controls.Add(_lblEnterGermanText, 0, 0);
        _mainLayoutPanel.Controls.Add(_txtPhoneticEnglish, 0, 3);
        _mainLayoutPanel.Controls.Add(_lblPhoneticEnglish, 0, 2);
        _mainLayoutPanel.Controls.Add(_btnAsyncPhoneticTranslate, 1, 1);
        _mainLayoutPanel.Controls.Add(_btnAsyncReadPhoneticEnglishOutLoud, 1, 3);
        _mainLayoutPanel.Dock = DockStyle.Fill;
        _mainLayoutPanel.Location = new Point(0, 0);
        _mainLayoutPanel.Margin = new Padding(4);
        _mainLayoutPanel.Name = "_mainLayoutPanel";
        _mainLayoutPanel.RowCount = 5;
        _mainLayoutPanel.RowStyles.Add(new RowStyle());
        _mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        _mainLayoutPanel.RowStyles.Add(new RowStyle());
        _mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        _mainLayoutPanel.RowStyles.Add(new RowStyle());
        _mainLayoutPanel.Size = new Size(1153, 674);
        _mainLayoutPanel.TabIndex = 10;
        // 
        // _germanTextPrompt
        // 
        _germanTextPrompt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _germanTextPrompt.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _germanTextPrompt.Location = new Point(4, 29);
        _germanTextPrompt.Margin = new Padding(4);
        _germanTextPrompt.Multiline = true;
        _germanTextPrompt.Name = "_germanTextPrompt";
        _germanTextPrompt.Size = new Size(873, 298);
        _germanTextPrompt.TabIndex = 8;
        _germanTextPrompt.Text = "Lerne Deutsch in nur 2 Minuten!\r\n\r\n";
        // 
        // _lblEnterGermanText
        // 
        _lblEnterGermanText.AutoSize = true;
        _lblEnterGermanText.Location = new Point(4, 0);
        _lblEnterGermanText.Margin = new Padding(4, 0, 4, 0);
        _lblEnterGermanText.Name = "_lblEnterGermanText";
        _lblEnterGermanText.Size = new Size(200, 25);
        _lblEnterGermanText.TabIndex = 1;
        _lblEnterGermanText.Text = "Enter the German text:";
        // 
        // _txtPhoneticEnglish
        // 
        _txtPhoneticEnglish.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _txtPhoneticEnglish.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _txtPhoneticEnglish.Location = new Point(4, 372);
        _txtPhoneticEnglish.Margin = new Padding(4);
        _txtPhoneticEnglish.Multiline = true;
        _txtPhoneticEnglish.Name = "_txtPhoneticEnglish";
        _txtPhoneticEnglish.Size = new Size(873, 298);
        _txtPhoneticEnglish.TabIndex = 2;
        // 
        // _lblPhoneticEnglish
        // 
        _lblPhoneticEnglish.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        _lblPhoneticEnglish.AutoSize = true;
        _lblPhoneticEnglish.Location = new Point(4, 343);
        _lblPhoneticEnglish.Margin = new Padding(4, 12, 4, 0);
        _lblPhoneticEnglish.Name = "_lblPhoneticEnglish";
        _lblPhoneticEnglish.Size = new Size(156, 25);
        _lblPhoneticEnglish.TabIndex = 3;
        _lblPhoneticEnglish.Text = "Phonetic English:";
        // 
        // _btnAsyncPhoneticTranslate
        // 
        _btnAsyncPhoneticTranslate.DialogResult = DialogResult.OK;
        _btnAsyncPhoneticTranslate.Location = new Point(911, 29);
        _btnAsyncPhoneticTranslate.Margin = new Padding(30, 4, 10, 10);
        _btnAsyncPhoneticTranslate.Name = "_btnAsyncPhoneticTranslate";
        _btnAsyncPhoneticTranslate.Size = new Size(232, 57);
        _btnAsyncPhoneticTranslate.TabIndex = 7;
        _btnAsyncPhoneticTranslate.Text = "Phonetic Translation";
        _btnAsyncPhoneticTranslate.UseVisualStyleBackColor = true;
        _btnAsyncPhoneticTranslate.AsyncClick += BtnAsyncPhoneticTranslate_AsyncClick;
        // 
        // _btnAsyncReadPhoneticEnglishOutLoud
        // 
        _btnAsyncReadPhoneticEnglishOutLoud.DialogResult = DialogResult.OK;
        _btnAsyncReadPhoneticEnglishOutLoud.Location = new Point(911, 372);
        _btnAsyncReadPhoneticEnglishOutLoud.Margin = new Padding(30, 4, 10, 10);
        _btnAsyncReadPhoneticEnglishOutLoud.Name = "_btnAsyncReadPhoneticEnglishOutLoud";
        _btnAsyncReadPhoneticEnglishOutLoud.Size = new Size(232, 57);
        _btnAsyncReadPhoneticEnglishOutLoud.TabIndex = 9;
        _btnAsyncReadPhoneticEnglishOutLoud.Text = "Read out loud!";
        _btnAsyncReadPhoneticEnglishOutLoud.UseVisualStyleBackColor = true;
        _btnAsyncReadPhoneticEnglishOutLoud.AsyncClick += BtnAsyncReadPhoneticEnglishOutLoud_AsyncClick;
        // 
        // _skPhoneticEnglish
        // 
        _skPhoneticEnglish.AssistantInstructions = resources.GetString("_skPhoneticEnglish.AssistantInstructions");
        _skPhoneticEnglish.Temperature = 1D;
        _skPhoneticEnglish.TopP = 1D;
        // 
        // LearnGermanDemo
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(_mainLayoutPanel);
        Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "LearnGermanDemo";
        Size = new Size(1153, 674);
        _mainLayoutPanel.ResumeLayout(false);
        _mainLayoutPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel _mainLayoutPanel;
    private SemanticKernelDemo.Controls.AsyncPromptControl _germanTextPrompt;
    private Label _lblEnterGermanText;
    private TextBox _txtPhoneticEnglish;
    private Label _lblPhoneticEnglish;
    private SemanticKernelDemo.Controls.AsyncButton _btnAsyncPhoneticTranslate;
    private SemanticKernelDemo.Controls.AsyncButton _btnAsyncReadPhoneticEnglishOutLoud;
    private SemanticKernelDemo.SemanticKernel.SemanticKernelComponent _skPhoneticEnglish;
}
