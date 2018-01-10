using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelhasznalokMasodikAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(session.SHA1("cica"));
            try
            {
                ABKezeles.Init(ConfigurationManager.ConnectionStrings["FelhasznalokMasodikAB.Properties.Settings.FelhasznalokMasodikConnectionString"].ConnectionString);
                BelepesFrm belepes = new BelepesFrm();
                if (belepes.ShowDialog() != DialogResult.OK)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ListBox feltöltése
            listBox1.DataSource = null;
            listBox1.DataSource = ABKezeles.Kiolvas();
            //ListView feltöltése
            listView1.Items.Clear();
            listView1.View = View.Details;
            ABKezeles.Kiolvas(listView1);
            //DataGridView feltöltése
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.AllowUserToAddRows = false;
            ABKezeles.Kiolvas(dataGridView1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ABKezeles.Torol((listBox1.SelectedItem as Felhasznalo));
                button1_Click(sender,e);
            }
        }
    }
}
