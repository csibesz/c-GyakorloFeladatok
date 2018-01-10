using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace _3.Feladat___SzovegSzerkeszto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            //File megnyitása
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string item in File.ReadAllLines(openFileDialog1.FileName, Encoding.Default))
                {
                    textBox1.Text += item + Environment.NewLine;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.FileName != "default")
            {
                File.WriteAllText(openFileDialog1.FileName, textBox1.Text);
            } else
            {
                //Fájl mentése másként
                btn_savas_Click(sender, e);
            }
        }

        private void btn_savas_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
                openFileDialog1.FileName = saveFileDialog1.FileName;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.SelectedText);
        }

        private void btn_cut_Click(object sender, EventArgs e)
        {
            btn_copy_Click(sender, e);
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart,textBox1.SelectionLength);
        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            if(Clipboard.ContainsText())
            {
                textBox1.Text = textBox1.Text.Insert(textBox1.SelectionStart, Clipboard.GetText());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true; -> Kilépés megszakítása ha igaz, akkor nem lép ki, ha a klilépés megszakítása hamis, akjkor kilép
            if(MessageBox.Show("Biztosan ki akar lépni?","Biztosan?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
