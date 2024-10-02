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
        tableLayoutPanel1 = new TableLayoutPanel();
        _germanTextPrompt = new SemanticKernelDemo.Controls.AsyncPromptControl();
        label1 = new Label();
        _txtPhoneticEnglish = new TextBox();
        label2 = new Label();
        _btnAsyncPhoneticTranslate = new SemanticKernelDemo.Controls.AsyncButton();
        _btnAsyncReadPhoneticEnglishOutLoud = new SemanticKernelDemo.Controls.AsyncButton();
        _skPhoneticEnglish = new SemanticKernelDemo.SemanticKernel.SemanticKernelComponent();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.Controls.Add(_germanTextPrompt, 0, 1);
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(_txtPhoneticEnglish, 0, 3);
        tableLayoutPanel1.Controls.Add(label2, 0, 2);
        tableLayoutPanel1.Controls.Add(_btnAsyncPhoneticTranslate, 1, 1);
        tableLayoutPanel1.Controls.Add(_btnAsyncReadPhoneticEnglishOutLoud, 1, 3);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Margin = new Padding(4);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.Size = new Size(1153, 674);
        tableLayoutPanel1.TabIndex = 10;
        // 
        // _germanTextPrompt
        // 
        _germanTextPrompt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _germanTextPrompt.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _germanTextPrompt.Location = new Point(4, 34);
        _germanTextPrompt.Margin = new Padding(4);
        _germanTextPrompt.Multiline = true;
        _germanTextPrompt.Name = "_germanTextPrompt";
        _germanTextPrompt.Size = new Size(873, 293);
        _germanTextPrompt.TabIndex = 8;
        _germanTextPrompt.Text = "Lerne Deutsch in nur 2 Minuten!\r\n\r\n";
        _germanTextPrompt.VisualStylesMode = VisualStylesMode.Latest;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(4, 0);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(230, 30);
        label1.TabIndex = 1;
        label1.Text = "Enter the German text:";
        // 
        // _txtPhoneticEnglish
        // 
        _txtPhoneticEnglish.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _txtPhoneticEnglish.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _txtPhoneticEnglish.Location = new Point(4, 377);
        _txtPhoneticEnglish.Margin = new Padding(4);
        _txtPhoneticEnglish.Multiline = true;
        _txtPhoneticEnglish.Name = "_txtPhoneticEnglish";
        _txtPhoneticEnglish.Size = new Size(873, 293);
        _txtPhoneticEnglish.TabIndex = 2;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        label2.AutoSize = true;
        label2.Location = new Point(4, 343);
        label2.Margin = new Padding(4, 12, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(174, 30);
        label2.TabIndex = 3;
        label2.Text = "Phonetic English:";
        // 
        // _btnAsyncPhoneticTranslate
        // 
        _btnAsyncPhoneticTranslate.DialogResult = DialogResult.OK;
        _btnAsyncPhoneticTranslate.Location = new Point(911, 34);
        _btnAsyncPhoneticTranslate.Margin = new Padding(30, 4, 10, 10);
        _btnAsyncPhoneticTranslate.Name = "_btnAsyncPhoneticTranslate";
        _btnAsyncPhoneticTranslate.Size = new Size(232, 103);
        _btnAsyncPhoneticTranslate.TabIndex = 7;
        _btnAsyncPhoneticTranslate.Text = "Phonetic Translation";
        _btnAsyncPhoneticTranslate.UseVisualStyleBackColor = true;
        _btnAsyncPhoneticTranslate.AsyncClick += BtnAsyncPhoneticTranslate_AsyncClick;
        // 
        // _btnAsyncReadPhoneticEnglishOutLoud
        // 
        _btnAsyncReadPhoneticEnglishOutLoud.DialogResult = DialogResult.OK;
        _btnAsyncReadPhoneticEnglishOutLoud.Location = new Point(911, 377);
        _btnAsyncReadPhoneticEnglishOutLoud.Margin = new Padding(30, 4, 10, 10);
        _btnAsyncReadPhoneticEnglishOutLoud.Name = "_btnAsyncReadPhoneticEnglishOutLoud";
        _btnAsyncReadPhoneticEnglishOutLoud.Size = new Size(232, 76);
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
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tableLayoutPanel1);
        Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4);
        Name = "LearnGermanDemo";
        Size = new Size(1153, 674);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private SemanticKernelDemo.Controls.AsyncPromptControl _germanTextPrompt;
    private Label label1;
    private TextBox _txtPhoneticEnglish;
    private Label label2;
    private SemanticKernelDemo.Controls.AsyncButton _btnAsyncPhoneticTranslate;
    private SemanticKernelDemo.Controls.AsyncButton _btnAsyncReadPhoneticEnglishOutLoud;
    private SemanticKernelDemo.SemanticKernel.SemanticKernelComponent _skPhoneticEnglish;
}
