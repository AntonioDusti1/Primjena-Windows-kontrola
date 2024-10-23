using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primjena_Windows_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string selectedProgram = comboBoxPrograms.SelectedItem.ToString();
            switch (selectedProgram)
            {
                case "Notepad":
                    System.Diagnostics.Process.Start("notepad.exe");
                    break;
                case "Paint":
                    System.Diagnostics.Process.Start("mspaint.exe");
                    break;
            }
        }

        private void checkBoxShowProgramAction_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxRunProgram.Visible = checkBoxShowProgramAction.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxProgramName.Clear();
            textBoxProgramDescription.Clear();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Želite li izaći?", "Potvrda izlaza", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ovo je informacijska poruka.", "Informacija", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FormaText FormaText = new FormaText();
            FormaText.ShowDialog();
            textBoxProgramName.Text = FormaText.textBox1;
            textBoxProgramDescription.Text = FormaText.textBox2;
        }
    }
}
