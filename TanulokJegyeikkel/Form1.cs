using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanulokJegyeikkel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UjTanulo dialogus = new UjTanulo();
            dialogus.ShowDialog();
            if(dialogus.DialogResult == DialogResult.OK)
            {
                listBox1.Items.Add(dialogus.LetrejottTanulo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1 && MessageBox.Show("Biztosan törli a tanulót?","Biztosan?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1 && listBox1.SelectedItem is Tanulo)
            {
                textBox1.Text = (listBox1.SelectedItem as Tanulo).JegyekSzovegesen();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && listBox1.SelectedItem is Tanulo)
            {
                (listBox1.SelectedItem as Tanulo).UjJegy((byte)numericUpDown1.Value);
                numericUpDown1.Value = 1;
                numericUpDown1.Focus();
                listBox1_SelectedIndexChanged(sender, e);
            }
        }
    }
}
