using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadeE_WIN
{
    public partial class Form2 : Form
    {
        Settings_File settings_ = new Settings_File();
        public Form2()
        {
            InitializeComponent();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticonePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(settings_.TopMost == false)
            {
                TopMost = false;
            }
            else
            {
                TopMost = true;
            }
        }

        private void siticoneCustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCustomCheckBox1.Checked == true)
            {
                TopMost = false;
                settings_.TopMost = false;
                label2.Text = "Puts ShadeE on top of most applications. [UNAPPLIED]";
                settings_.Save();
                siticoneCustomCheckBox1.Checked = false;
            }
            else
            {
                TopMost = true;
                settings_.TopMost = true;
                label2.Text = "Puts ShadeE on top of most applications. [APPLIED]";
                settings_.Save();
                siticoneCustomCheckBox1.Checked = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
