namespace DarkModeDemo;

public class DarkModeAndVisualStylesModeTesting
{
    public class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // TestForm
            // 
            ClientSize = new System.Drawing.Size(800, 450);
            Name = "TestForm";
            Text = "TestForm";
            ResumeLayout(false);
        }
    }
    public DarkModeAndVisualStylesModeTesting()
    {
        Application.SetDefaultVisualStylesMode(VisualStylesMode.Classic);
        Application.SetColorMode(SystemColorMode.System);
        Application.Run(new TestForm());
    }
}
