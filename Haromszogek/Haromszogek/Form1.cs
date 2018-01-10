using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haromszogek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //1.7 - 1.8 feladat 
        private void btn_AdatokBetoltese_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            List<DHaromszog> haromszogList = new List<DHaromszog>();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //listBox_HaromszogekLista.Items.Clear();
                listBox_HibaLista.Items.Clear();
                haromszogList.Clear();
                l_keruletErtek.Text = string.Empty;
                l_teruletErtek.Text = string.Empty;

                StreamReader sR = new StreamReader(fileDialog.FileName);

                string sor;
                int sorSzam = 0;
                while ((sor = sR.ReadLine()) != null)
                {
                    sorSzam++;
                    try
                    {
                        DHaromszog ujHaromszog = new DHaromszog(sor, sorSzam);
                        haromszogList.Add(ujHaromszog);
                    }
                    catch (Exception ex)
                    {
                        listBox_HibaLista.Items.Add(ex.Message);
                    }

                }

                listBox_HaromszogekLista.DataSource = haromszogList;

                sR.Close();
                sR.Dispose();

            }
        }
        //1.10 feladat
        private void listBox_HaromszogekLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            DHaromszog kivalasztottHaromszog = listBox_HaromszogekLista.SelectedItem as DHaromszog;
            l_keruletErtek.Text = kivalasztottHaromszog.Kerulet.ToString();
            l_teruletErtek.Text = kivalasztottHaromszog.Terulet.ToString();
        }
    }
}
