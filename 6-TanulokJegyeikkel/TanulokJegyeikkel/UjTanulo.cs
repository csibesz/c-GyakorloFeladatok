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
    public partial class UjTanulo : Form
    {
        Tanulo letrejottTanulo;

        internal Tanulo LetrejottTanulo
        {
            get { return letrejottTanulo; }
        }

        public UjTanulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim().Length >= 3)
            {
                letrejottTanulo = new Tanulo(textBox1.Text);
            } else
            {
                MessageBox.Show("A név legalább 3 karakter kell hogy legyen!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
        }
    }
}
