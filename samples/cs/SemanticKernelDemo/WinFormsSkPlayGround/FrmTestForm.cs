using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSkPlayGround
{
    public partial class FrmTestForm : Form
    {
        public FrmTestForm()
        {
            InitializeComponent();
        }

        private void floatingPointTrackBar1_Scroll(object sender, EventArgs e)
        {
            _lblValue.Text = $"Value: {floatingPointTrackBar1.Value}";
        }
    }
}
