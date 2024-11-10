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
        _mainLayoutPanel = new TableLayoutPanel();
        _lblEnterGermanText = new Label();
        _txtPhoneticEnglish = new TextBox();
        _lblPhoneticEnglish = new Label();
        _cmbDeutscheTextBeispiele = new ComboBox();
        _mainLayoutPanel.SuspendLayout();
        SuspendLayout();
        // 
        // _mainLayoutPanel
        // 
        _mainLayoutPanel.ColumnCount = 2;
        _mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        _mainLayoutPanel.ColumnStyles.Add(new ColumnStyle());
        _mainLayoutPanel.Controls.Add(_lblEnterGermanText, 0, 0);
        _mainLayoutPanel.Controls.Add(_txtPhoneticEnglish, 0, 6);
        _mainLayoutPanel.Controls.Add(_lblPhoneticEnglish, 0, 5);
        _mainLayoutPanel.Controls.Add(_cmbDeutscheTextBeispiele, 0, 1);
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
        // _txtPhoneticEnglish
        // 
        _txtPhoneticEnglish.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _txtPhoneticEnglish.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
        _txtPhoneticEnglish.Location = new Point(4, 391);
        _txtPhoneticEnglish.Margin = new Padding(4);
        _txtPhoneticEnglish.Multiline = true;
        _txtPhoneticEnglish.Name = "_txtPhoneticEnglish";
        _txtPhoneticEnglish.Size = new Size(1145, 279);
        _txtPhoneticEnglish.TabIndex = 5;
        // 
        // _lblPhoneticEnglish
        // 
        _lblPhoneticEnglish.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        _lblPhoneticEnglish.AutoSize = true;
        _lblPhoneticEnglish.Location = new Point(4, 362);
        _lblPhoneticEnglish.Margin = new Padding(4, 12, 4, 0);
        _lblPhoneticEnglish.Name = "_lblPhoneticEnglish";
        _lblPhoneticEnglish.Size = new Size(156, 25);
        _lblPhoneticEnglish.TabIndex = 4;
        _lblPhoneticEnglish.Text = "Phonetic English:";
        // 
        // _cmbDeutscheTextBeispiele
        // 
        _cmbDeutscheTextBeispiele.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        _cmbDeutscheTextBeispiele.FormattingEnabled = true;
        _cmbDeutscheTextBeispiele.Items.AddRange(new object[] { "Lerne Deutsch in nur zwei Minuten!", "Hast du etwas Zeit für mich, dann singe ich ein Lied für dich, von 99 Luftballons.", "In München steht ein Hofbräuhaus, oans, zwoa, gsuffa!", "Marmor Stein und Eisen bricht, aber unsere Liebe nicht.", "Völlig losgelöst von der Erde schwebt das Raumschiff völlig schwerelos.", "" });
        _cmbDeutscheTextBeispiele.Location = new Point(5, 30);
        _cmbDeutscheTextBeispiele.Margin = new Padding(5);
        _cmbDeutscheTextBeispiele.Name = "_cmbDeutscheTextBeispiele";
        _cmbDeutscheTextBeispiele.Size = new Size(1143, 33);
        _cmbDeutscheTextBeispiele.TabIndex = 1;
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
    private ComboBox _cmbDeutscheTextBeispiele;
}
