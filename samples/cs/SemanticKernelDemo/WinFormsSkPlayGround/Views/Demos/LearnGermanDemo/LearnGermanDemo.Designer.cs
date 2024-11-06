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
        _lblEnterGermanText = new Label();
        _btnAsyncReadPhoneticEnglishOutLoud = new SemanticKernelDemo.Controls.AsyncButton();
        _txtPhoneticEnglish = new TextBox();
        _lblPhoneticEnglish = new Label();
        _txtGermanTextPrompt = new SemanticKernelDemo.Controls.AsyncPromptControl();
        _cmbDeutscheTextBeispiele = new ComboBox();
        _btnAsyncPhoneticTranslate = new SemanticKernelDemo.Controls.AsyncButton();
        _skPhoneticEnglish = new SemanticKernelDemo.SemanticKernel.SemanticKernelComponent();
        _mainLayoutPanel.SuspendLayout();
        SuspendLayout();
        // 
        // _mainLayoutPanel
        // 
        _mainLayoutPanel.ColumnCount = 2;
        _mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        _mainLayoutPanel.ColumnStyles.Add(new ColumnStyle());
        _mainLayoutPanel.Controls.Add(_lblEnterGermanText, 0, 0);
        _mainLayoutPanel.Controls.Add(_btnAsyncReadPhoneticEnglishOutLoud, 1, 3);
        _mainLayoutPanel.Controls.Add(_txtPhoneticEnglish, 0, 6);
        _mainLayoutPanel.Controls.Add(_lblPhoneticEnglish, 0, 5);
        _mainLayoutPanel.Controls.Add(_txtGermanTextPrompt, 0, 3);
        _mainLayoutPanel.Controls.Add(_cmbDeutscheTextBeispiele, 0, 1);
        _mainLayoutPanel.Controls.Add(_btnAsyncPhoneticTranslate, 1, 0);
        _mainLayoutPanel.Dock = DockStyle.Fill;
        _mainLayoutPanel.Location = new Point(0, 0);
        _mainLayoutPanel.Margin = new Padding(4);
        _mainLayoutPanel.Name = "_mainLayoutPanel";
        _mainLayoutPanel.RowCount = 7;
        _mainLayoutPanel.RowStyles.Add(new RowStyle());
        _mainLayoutPanel.RowStyles.Add(new RowStyle());
        _mainLayoutPanel.RowStyles.Add(new RowStyle());
        _mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        _mainLayoutPanel.RowStyles.Add(new RowStyle());
        _mainLayoutPanel.RowStyles.Add(new RowStyle());
        _mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        _mainLayoutPanel.Size = new Size(1153, 674);
        _mainLayoutPanel.TabIndex = 10;
        // 
        // _lblEnterGermanText
        // 
        _lblEnterGermanText.AutoSize = true;
        _lblEnterGermanText.Location = new Point(4, 0);
        _lblEnterGermanText.Margin = new Padding(4, 0, 4, 0);
        _lblEnterGermanText.Name = "_lblEnterGermanText";
        _lblEnterGermanText.Size = new Size(200, 25);
        _lblEnterGermanText.TabIndex = 0;
        _lblEnterGermanText.Text = "Enter the German text:";
        // 
        // _btnAsyncReadPhoneticEnglishOutLoud
        // 
        _btnAsyncReadPhoneticEnglishOutLoud.DialogResult = DialogResult.OK;
        _btnAsyncReadPhoneticEnglishOutLoud.Location = new Point(911, 75);
        _btnAsyncReadPhoneticEnglishOutLoud.Margin = new Padding(30, 4, 10, 10);
        _btnAsyncReadPhoneticEnglishOutLoud.Name = "_btnAsyncReadPhoneticEnglishOutLoud";
        _btnAsyncReadPhoneticEnglishOutLoud.Size = new Size(232, 57);
        _btnAsyncReadPhoneticEnglishOutLoud.TabIndex = 0;
        _btnAsyncReadPhoneticEnglishOutLoud.Text = "Read out loud!";
        _btnAsyncReadPhoneticEnglishOutLoud.UseVisualStyleBackColor = true;
        _btnAsyncReadPhoneticEnglishOutLoud.AsyncClick += BtnAsyncReadPhoneticEnglishOutLoud_AsyncClick;
        // 
        // _txtPhoneticEnglish
        // 
        _txtPhoneticEnglish.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _txtPhoneticEnglish.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _txtPhoneticEnglish.Location = new Point(4, 395);
        _txtPhoneticEnglish.Margin = new Padding(4);
        _txtPhoneticEnglish.Multiline = true;
        _txtPhoneticEnglish.Name = "_txtPhoneticEnglish";
        _txtPhoneticEnglish.Size = new Size(873, 275);
        _txtPhoneticEnglish.TabIndex = 5;
        // 
        // _lblPhoneticEnglish
        // 
        _lblPhoneticEnglish.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        _lblPhoneticEnglish.AutoSize = true;
        _lblPhoneticEnglish.Location = new Point(4, 366);
        _lblPhoneticEnglish.Margin = new Padding(4, 12, 4, 0);
        _lblPhoneticEnglish.Name = "_lblPhoneticEnglish";
        _lblPhoneticEnglish.Size = new Size(156, 25);
        _lblPhoneticEnglish.TabIndex = 4;
        _lblPhoneticEnglish.Text = "Phonetic English:";
        // 
        // _txtGermanTextPrompt
        // 
        _txtGermanTextPrompt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _txtGermanTextPrompt.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _txtGermanTextPrompt.Location = new Point(4, 75);
        _txtGermanTextPrompt.Margin = new Padding(4);
        _txtGermanTextPrompt.Multiline = true;
        _txtGermanTextPrompt.Name = "_txtGermanTextPrompt";
        _txtGermanTextPrompt.Size = new Size(873, 275);
        _txtGermanTextPrompt.TabIndex = 3;
        _txtGermanTextPrompt.Text = "Lerne Deutsch in nur 2 Minuten!\r\n\r\n";
        // 
        // _cmbDeutscheTextBeispiele
        // 
        _cmbDeutscheTextBeispiele.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _cmbDeutscheTextBeispiele.FormattingEnabled = true;
        _cmbDeutscheTextBeispiele.Items.AddRange(new object[] { "Lerne Deutsch in nur zwei Minuten!", "Hast du etwas Zeit für mich, dann singe ich ein Lied für dich, von 99 Luftballons.", "In München steht ein Hofbräuhaus, oans, zwoa, gsuffa!", "Marmor Stein und Eisen bricht, aber unsere Liebe nicht.", "Völlig losgelöst von der Erde schwebt das Raumschiff völlig schwerelos.", "" });
        _cmbDeutscheTextBeispiele.Location = new Point(5, 30);
        _cmbDeutscheTextBeispiele.Margin = new Padding(5);
        _cmbDeutscheTextBeispiele.Name = "_cmbDeutscheTextBeispiele";
        _cmbDeutscheTextBeispiele.Size = new Size(871, 33);
        _cmbDeutscheTextBeispiele.TabIndex = 1;
        // 
        // _btnAsyncPhoneticTranslate
        // 
        _btnAsyncPhoneticTranslate.DialogResult = DialogResult.OK;
        _btnAsyncPhoneticTranslate.Location = new Point(911, 4);
        _btnAsyncPhoneticTranslate.Margin = new Padding(30, 4, 10, 10);
        _btnAsyncPhoneticTranslate.Name = "_btnAsyncPhoneticTranslate";
        _mainLayoutPanel.SetRowSpan(_btnAsyncPhoneticTranslate, 2);
        _btnAsyncPhoneticTranslate.Size = new Size(232, 57);
        _btnAsyncPhoneticTranslate.TabIndex = 6;
        _btnAsyncPhoneticTranslate.Text = "Phonetic Translation";
        _btnAsyncPhoneticTranslate.UseVisualStyleBackColor = true;
        _btnAsyncPhoneticTranslate.AsyncClick += BtnAsyncPhoneticTranslate_AsyncClick;
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
    private SemanticKernelDemo.Controls.AsyncPromptControl _txtGermanTextPrompt;
    private Label _lblEnterGermanText;
    private TextBox _txtPhoneticEnglish;
    private Label _lblPhoneticEnglish;
    private SemanticKernelDemo.Controls.AsyncButton _btnAsyncPhoneticTranslate;
    private SemanticKernelDemo.Controls.AsyncButton _btnAsyncReadPhoneticEnglishOutLoud;
    private SemanticKernelDemo.SemanticKernel.SemanticKernelComponent _skPhoneticEnglish;
    private ComboBox _cmbDeutscheTextBeispiele;
}
