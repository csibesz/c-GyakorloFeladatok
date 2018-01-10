using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Feladat___SzamokDialogus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Interaction -> Microsoft.VisualBasic
            int osszeg = 0;
            int szorzat = 1;

            while(osszeg < 100)
            {
                int tmp = Convert.ToInt32(Interaction.InputBox("Adja meg a következő számot","Számbekérés...","10"));
                osszeg += tmp;
                szorzat *= tmp;
            }
            MessageBox.Show("A megadott számok szorzata: " + szorzat, "Eredmény...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
