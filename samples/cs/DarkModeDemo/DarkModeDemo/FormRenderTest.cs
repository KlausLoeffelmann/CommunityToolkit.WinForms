using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkModeDemo
{
    public partial class FormRenderTest : Form
    {
        public FormRenderTest()
        {
            InitializeComponent();
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var bounds = panel1.ClientRectangle;
            bounds.Inflate(-40, -40);

            var clipBounds = bounds;
            clipBounds.Inflate(-40, -40);

            e.Graphics.ExcludeClip(clipBounds);

            e.Graphics.TranslateTransform(100, 100);

            // draw a blue filled rectangle
            e.Graphics.FillRectangle(Brushes.Blue, bounds);


            // draw a red rectangle with clipping
            e.Graphics.FillRectangle(Brushes.Yellow, clipBounds);
        }

        private void FormRenderTest_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = this;
        }
    }
}
