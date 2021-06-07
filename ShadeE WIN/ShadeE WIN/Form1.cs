using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;


namespace ShadeE_WIN
{
    public partial class Form1 : Form
    {
        WeAreDevs_API.ExploitAPI api = new WeAreDevs_API.ExploitAPI();

        Executor_Tab executor_ = new Executor_Tab();
        Options_Tab options_ = new Options_Tab();
        ScriptHUB_Tab scriptHUB_ = new ScriptHUB_Tab();
        GameHUB_tab gameHUB_ = new GameHUB_tab();

        Form2 f2 = new Form2();

        Settings_File settings_ = new Settings_File();
        public Form1()
        {
            InitializeComponent();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            if (siticoneButton5.Checked) infoTab1.BringToFront();
        }

        private void SettingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            if (siticoneButton4.Checked) options_Tab1.BringToFront();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                if (settings_.TopMost == false)
                {
                    TopMost = false;
                }
                else
                {
                    TopMost = true;
                }
            }
        }

        private void settings1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if (siticoneButton2.Checked) scriptHUB_Tab1.BringToFront();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (siticoneButton1.Checked) gameHUB_tab1.BringToFront();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            if (siticoneButton3.Checked) executor_Tab1.BringToFront();
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void options_Tab1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {
        }

        private void siticoneRoundedButton5_Click_1(object sender, EventArgs e)
        {
        }

        private void siticoneRoundedButton4_Click_1(object sender, EventArgs e)
        {
            f2.Show();
        }
    }
}
