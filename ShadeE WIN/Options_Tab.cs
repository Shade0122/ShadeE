using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using WeAreDevs_API;

namespace ShadeE_WIN
{
    public partial class Options_Tab : UserControl
    {
        WeAreDevs_API.ExploitAPI api = new WeAreDevs_API.ExploitAPI();
        public Options_Tab()
        {
            InitializeComponent();
        }

        private void siticoneWinToggleSwith1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Process[] roblox = Process.GetProcesses();
            foreach (Process RobloxProcess in roblox)
            {
                bool flag = RobloxProcess.ProcessName == "RobloxPlayerBeta";
                if (flag)
                {
                    RobloxProcess.Kill();
                }
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Process.Start(@".\rbxfpsunlocker.exe");
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Process.Start(@".\Multiple_ROBLOX.exe");
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            Process.Start(@".\Lag Switch.exe");
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        { 
        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
        }

        private void siticoneButton8_Click_1(object sender, EventArgs e)
        {
        }

        private void Options_Tab_Load(object sender, EventArgs e)
        {

        }

        private void siticoneWinToggleSwith1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneWinToggleSwith1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void siticoneCustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void siticonePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton5_Click_1(object sender, EventArgs e)
        {
            if (siticoneTextBox1.Text == "cmds")
            {
                richTextBox1.Text =
                    "List of commands available with ShadeE: " +
                    "\n--------------------------------------------------------------------------" + 
                    "\nWalkspeed | ws <value> | (16, 20, 40, 60, 80, 100, 120, 140, 160, 180, 200)" +
                    "\nJumppower | jp <value> | (50, 75, 100, 125, 150, 175, 200, 225, 250)" +
                    "\nFly/Unfly | fly/unfly | Lets your character fly or unfly." +
                    "\nCredits | credit | Prints all credits inside the ROBLOX console (f9).";
            }
        }
    }
}
