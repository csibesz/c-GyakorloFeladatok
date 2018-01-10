using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCRaktar
{
    /// <summary>
    /// </summary>
    public partial class Form1 : Form
    {
        List<Termekek> termek; 
        /// <summary>
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            termek = new List<Termekek>();
            //Zoldsegek z = new Zoldsegek(false,"Uborka","12334565qwer",100,3);
            //z.Cikkszam = "qwert";
        }

        void ListBoxRefresh()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = termek;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 &&
                MessageBox.Show("Biztosan törölni akarja a terméket?", "Biztosan?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                termek.RemoveAt(listBox1.SelectedIndex);
                ListBoxRefresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UjTermek dialogus = new UjTermek();
            if (dialogus.ShowDialog() == DialogResult.OK)
            {
                termek.Add(dialogus.Tarolt);
                ListBoxRefresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                UjTermek dialogus = new UjTermek((Termekek)listBox1.SelectedItem);
                dialogus.ShowDialog();
                ListBoxRefresh();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                numericUpDown1.Value = (listBox1.SelectedItem as Termekek).Db;
                button4.Enabled = true;
            }
            else
            {
                numericUpDown1.Value = 0;
                button4.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (listBox1.SelectedItem as Termekek).Db = (int) numericUpDown1.Value;
            ListBoxRefresh();
        }
    }
}
