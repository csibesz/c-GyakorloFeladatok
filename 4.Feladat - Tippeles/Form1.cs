using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Feladat___Tippeles
{
    public partial class Form1 : Form
    {
        int szam;

        public Form1()
        {
            InitializeComponent();
        }

        private void ujjatek_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            szam = r.Next(1, 100);
            label1.Text = "Gondoltam egy számra 1 -100 között";
            textBox1.Text = "";
            listBox1.Items.Clear();
            tippel.Enabled = true;
        }

        private void tippel_Click(object sender, EventArgs e)
        {
            int tipp = Convert.ToInt32(textBox1.Text);

            if (tipp > szam)
            {
                label1.Text = "Ennél kissebb számra gondoltam";
            }
            else if (tipp < szam)
            {
                label1.Text = "Ennél nagyobb számra gondoltam";
            }
            else
            {
                label1.Text = "ZSÍROSKENYÉR!!!!!!!";
                tippel.Enabled = false;
            }
            listBox1.Items.Add(tipp + " - " + label1.Text);
            textBox1.Text = "";
            textBox1.Focus(); //Visszaugrik a textbox1 -be a kurzor (azaz fókuszt kap)
        }
    }
}
