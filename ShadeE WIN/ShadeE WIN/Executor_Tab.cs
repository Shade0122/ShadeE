using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WeAreDevs_API;

namespace ShadeE_WIN
{
    public partial class Executor_Tab : UserControl
    {
        WeAreDevs_API.ExploitAPI api = new WeAreDevs_API.ExploitAPI();
        public Executor_Tab()
        {
            InitializeComponent();
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            string script = fastColoredTextBox1.Text;
                api.SendLimitedLuaScript(script);
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void siticoneButton6_Click_1(object sender, EventArgs e)
        {
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileOpen = new OpenFileDialog();
            FileOpen.Title = "ShadeE | Open-File";
            FileOpen.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";
            if (FileOpen.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Text = File.ReadAllText(FileOpen.FileName);
            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            SaveFileDialog FileSave = new SaveFileDialog();
            FileSave.Title = "ShadeE | Save-File";
            FileSave.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";
            if (FileSave.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(FileSave.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileExecute = new OpenFileDialog();
            FileExecute.Title = "ShadeE | Execute-File";
            FileExecute.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";
            if (FileExecute.ShowDialog() == DialogResult.OK)
            {
                api.SendLimitedLuaScript(File.ReadAllText(FileExecute.FileName));
            }
        }

        private void Executor_Tab_Load(object sender, EventArgs e)
        {
        }
    }
}
