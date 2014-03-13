using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace Sudoku
{
    public partial class frm_Sukudo : Form
    {
        public frm_Sukudo()
        {
            InitializeComponent();
        }
        private void cmd_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (e.KeyChar == (char)8)
                e.Handled = false;
            else if (txt.Text.Length == 1 || e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int widht = pn_Table.Width / 11;
            int height = pn_Table.Height / 11;
            for (int i = 1; i < 12; i++)
                if (i % 4 != 0)
                    for (int j = 1; j < 12; j++)
                        if (j % 4 != 0)
                        {
                            TextBox txtbox = new TextBox();
                            txtbox.Height = height;
                            txtbox.Width = widht;
                            txtbox.Top = (i - 1) * height;
                            txtbox.Left = (j - 1) * widht;
                            txtbox.KeyPress += new KeyPressEventHandler(txtbox_KeyPress);
                            txtbox.TextAlign = HorizontalAlignment.Center;
                            pn_Table.Controls.Add(txtbox);
                        }
        }
        private void cmd_New_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pn_Table.Controls.Count; i++)
            {
                pn_Table.Controls[i].Enabled = true;
                pn_Table.Controls[i].Text = "";
            }
            pn_Table.Controls[0].Focus();
        }
        private void cmd_Slove_Click(object sender, EventArgs e)
        {
            StreamWriter fw = new StreamWriter("input.txt");
            for (int i = 0; i < pn_Table.Controls.Count; i++)
            {
                if (pn_Table.Controls[i].Text == "")
                    fw.WriteLine("0");
                else
                {
                    fw.WriteLine(pn_Table.Controls[i].Text);
                    pn_Table.Controls[i].Enabled = false;
                }
            }
            fw.Close();

            Process process;
            process = System.Diagnostics.Process.Start("CoreSudokuSolver.exe");
            process.WaitForExit();

            StreamReader fr = new StreamReader("output.txt");
            string s = fr.ReadLine();
            if (s == "No Solution")
            {
                MessageBox.Show("No solution");
            }
            else
            {
                pn_Table.Controls[0].Text = s;
                for (int i = 1; i < pn_Table.Controls.Count; i++)
                    pn_Table.Controls[i].Text = fr.ReadLine();
            }
            fr.Close();
        }
        private void EnableAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pn_Table.Controls.Count; i++)
                pn_Table.Controls[i].Enabled = true;
        }
        private void cmd_EmptyTheAnswers_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pn_Table.Controls.Count; i++)
                if (pn_Table.Controls[i].Enabled)
                    pn_Table.Controls[i].Text = "";
                else
                    pn_Table.Controls[i].Enabled = true;
        }

        private void frm_Sukudo_Shown(object sender, EventArgs e)
        {
            pn_Table.Controls[0].Focus();
        }
    }
}