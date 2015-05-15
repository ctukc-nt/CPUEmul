using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUEmul.Model;

namespace CPUEmul
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            var result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                LoadTextStringFromFile loader = new LoadTextStringFromFile();
                var content = loader.ReadTextFileToEnd(ofd.FileName);
                rtbTextProgram.Text = content;
            }
        }

        private void bSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            var result = sfd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                SaveTextStringToFile saver = new SaveTextStringToFile();
                saver.WriteStringToFile(sfd.FileName, rtbTextProgram.Text);
            }
        }

        private void bClearTextProg_Click(object sender, EventArgs e)
        {
            rtbTextProgram.Text = string.Empty;
        }
    }
}
