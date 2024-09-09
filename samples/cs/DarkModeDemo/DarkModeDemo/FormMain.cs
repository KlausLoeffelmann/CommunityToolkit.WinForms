
using System.Diagnostics;

namespace DarkModeDemo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Invalidate(true);
        }

        private void OptClassic_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutPanel1.SuspendLayout();

            // Iterate through all the controls in the TableLayoutPanel and set the VisualStyleMode to Classic:
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                // If the control is a TextBox, set the BorderStyle to none:
                if (control is TextBox textBox)
                {
                    textBox.BorderStyle = BorderStyle.None;
                    control.VisualStylesMode = VisualStylesMode.Classic;
                    textBox.Margin = new(2);
                }

                if (control is CheckBox checkBox)
                {
                    control.VisualStylesMode = VisualStylesMode.Classic;
                    checkBox.Margin = new(5);
                }
            }

            tableLayoutPanel1.ResumeLayout();
        }

        private void OptA11Y_CheckedChanged(object sender, EventArgs e)
        {
            tableLayoutPanel1.SuspendLayout();

            // Iterate through all the controls in the TableLayoutPanel and set the VisualStyleMode to Classic:
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                // If the control is a TextBox, set the BorderStyle to none:
                if (control is TextBox textBox)
                {
                    control.VisualStylesMode = VisualStylesMode.Latest;
                    textBox.BorderStyle = BorderStyle.Fixed3D;
                    textBox.Padding = new(3);
                    textBox.Margin = new(10);
                }

                if (control is CheckBox checkBox)
                {
                    control.VisualStylesMode = VisualStylesMode.Latest;
                    checkBox.Margin = new(20);
                }
            }

            tableLayoutPanel1.ResumeLayout();
        }

        private void FormMain_FormCaptionBackColorChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("FormMain_FormCaptionBackColorChanged");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBorderColor = Color.Red;
            Debug.Print($"FormBorderColor: {FormBorderColor}");
            // FormCaptionTextColor = Color.White;
            Debug.Print($"FormCaptionTextColor: {FormCaptionTextColor}");
            // FormCaptionBackColor = Color.Blue;
            Debug.Print($"FormCaptionBackColor: {FormCaptionBackColor}");
        }
    }
}
