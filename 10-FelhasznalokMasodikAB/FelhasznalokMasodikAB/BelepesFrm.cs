using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelhasznalokMasodikAB
{
    public partial class BelepesFrm : Form
    {
        public BelepesFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || (session.JelenlegiFelhasznalo = ABKezeles.Beleptetes(textBox1.Text.Trim(), session.SHA1(textBox2.Text))) == null)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Hibás felhasználónév vagy Jelszó");
            }
        }
    }
}
