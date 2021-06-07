using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShadeE_WIN.Properties;
using System.Net;
using WeAreDevs_API;

namespace ShadeE_WIN
{
    public partial class ScriptHUB_Tab : UserControl
    {
        WeAreDevs_API.ExploitAPI api = new WeAreDevs_API.ExploitAPI();
        WebClient webClient = new WebClient();
        public ScriptHUB_Tab()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yes = listBox1.Text;
            if (yes == "Reviz Admin")
            {
                richTextBox1.Text = "Created by illremember#3799, Reviz Admin is one of the best admin scripts out there that are supported by all FREE exploits. Use the prefix ; for cmds.";
                pictureBox1.Image = Resources.Unavailable;
            }

            string yes1 = listBox1.Text;
            if (yes1 == "ShadeHUB")
            {
                richTextBox1.Text = "Created by Shade#0122, ShadeHUB is currently in development and hasnt been released to the public quite yet. Updates of the script are posted on there discord server: NIL";
                pictureBox1.Image = Resources.Unavailable;
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string yes = listBox1.Text;
            if (yes == "Reviz Admin")
            {

                string script1 = webClient.DownloadString("https://pastebin.com/raw/XuZ3QLFF");
                api.SendLimitedLuaScript(script1);
            }

            string yes1 = listBox1.Text;
            if (yes1 == "ShadeHUB")
            {
                string script2 = webClient.DownloadString("");
                api.SendLimitedLuaScript("");
            }
        }

        private void ScriptHUB_Tab_Load(object sender, EventArgs e)
        {

        }
    }
}
