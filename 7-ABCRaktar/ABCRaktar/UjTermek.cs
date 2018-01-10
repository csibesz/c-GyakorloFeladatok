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
    enum TermekKategoria
    {
        Termék,
        Tej,
        Pékárú,
        Zöldség
    }
    /// <summary>
    /// </summary>
    public partial class UjTermek : Form
    {
        Termekek tarolt;

        internal Termekek Tarolt
        {
            get { return tarolt; }
        }

        NumericUpDown zsirtartalom_nu;
        ComboBox tejkategoria_cb;
        CheckBox teljeskiorlesu_check;
        CheckBox gyumolcs_check;

        /// <summary>
        /// </summary>
        public UjTermek()
        {
            InitializeComponent();
            KomponensLetrehozasa();
            comboBox1.DataSource = Enum.GetValues(typeof (TermekKategoria));
        }

        internal UjTermek(Termekek modosit)
        {
            InitializeComponent();
            KomponensLetrehozasa();
            comboBox1.DataSource = Enum.GetValues(typeof(TermekKategoria));
            textBox1.Text = modosit.Megnevezes;
            textBox2.Text = modosit.Cikkszam;
            textBox2.ReadOnly = true;
            numericUpDown1.Value = modosit.Ar;
            numericUpDown2.Value = modosit.Db;
            tarolt = modosit;
            if (modosit is TejTermekek)
            {
                comboBox1.SelectedIndex = (int) TermekKategoria.Tej;
                zsirtartalom_nu.Value = (decimal)(modosit as TejTermekek).ZsirTartalom;
                tejkategoria_cb.SelectedIndex = (int)(modosit as TejTermekek).Tipus;
            }
            else if (modosit is Pekaru)
            {
                comboBox1.SelectedIndex = (int) TermekKategoria.Pékárú;
                teljeskiorlesu_check.Checked = (modosit as Pekaru).TeljesKiorlesu;
            }
            else if (modosit is Zoldsegek)
            {
                comboBox1.SelectedIndex = (int)TermekKategoria.Zöldség;
                gyumolcs_check.Checked = (modosit as Zoldsegek).Gyumolcs;
            }
            comboBox1.Enabled = false;
        }

        void KomponensLetrehozasa()
        {
            zsirtartalom_nu = new NumericUpDown()
            {
                Parent = groupBox1,
                Top = 10,
                Left = groupBox1.Width / 2,
                Width = groupBox1.Width / 2 -10,
                Minimum = 0,
                Maximum = 100,
                DecimalPlaces = 2,
                Increment = (decimal)0.1   
            };
            tejkategoria_cb = new ComboBox()
            {
                Parent = groupBox1,
                Top = zsirtartalom_nu.Bottom + 5,
                Left = groupBox1.Width / 2,
                Width = groupBox1.Width / 2 - 10,
                DropDownStyle = ComboBoxStyle.DropDownList,
                DataSource = Enum.GetValues(typeof(TejTermekTipus)),
                Visible = false
            };
            teljeskiorlesu_check = new CheckBox()
            {
                Parent = groupBox1,
                Top = 10,
                Left = groupBox1.Width / 2,
                Width = groupBox1.Width / 2 - 10,
                Text = "Teljeskiörlésű",
                Visible = false
            };
            gyumolcs_check = new CheckBox()
            {
                Parent = groupBox1,
                Top = 10,
                Left = groupBox1.Width / 2,
                Width = groupBox1.Width / 2 - 10,
                Text = "Termék gyümölcs",
                Visible = false
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tarolt != null && textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                tarolt.Megnevezes = textBox1.Text;
                tarolt.Ar = (int) numericUpDown1.Value;
                tarolt.Db = (int) numericUpDown2.Value;
                switch ((TermekKategoria) comboBox1.SelectedIndex)
                {
                    case TermekKategoria.Tej:
                        (tarolt as TejTermekek).ZsirTartalom = (double) zsirtartalom_nu.Value;
                        (tarolt as TejTermekek).Tipus = (TejTermekTipus) tejkategoria_cb.SelectedIndex;
                        break;
                    case TermekKategoria.Pékárú:
                        (tarolt as Pekaru).TeljesKiorlesu = teljeskiorlesu_check.Checked;
                        break;
                    case TermekKategoria.Zöldség:
                        (tarolt as Zoldsegek).Gyumolcs = gyumolcs_check.Checked;
                        break;
                }
            }
            else if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                switch ((TermekKategoria) comboBox1.SelectedIndex)
                {
                    case TermekKategoria.Termék:
                        tarolt = new Termekek(textBox1.Text, textBox2.Text, (int) numericUpDown2.Value,
                            (int) numericUpDown1.Value);
                        break;
                    case TermekKategoria.Tej:
                        tarolt = new TejTermekek((double) zsirtartalom_nu.Value,
                            (TejTermekTipus) tejkategoria_cb.SelectedIndex, textBox1.Text, textBox2.Text,
                            (int) numericUpDown2.Value, (int) numericUpDown1.Value);
                        break;
                    case TermekKategoria.Pékárú:
                        tarolt = new Pekaru(teljeskiorlesu_check.Checked, textBox1.Text, textBox2.Text,
                            (int) numericUpDown2.Value, (int) numericUpDown1.Value);
                        break;
                    case TermekKategoria.Zöldség:
                        tarolt = new Zoldsegek(gyumolcs_check.Checked, textBox1.Text, textBox2.Text,
                            (int) numericUpDown2.Value, (int) numericUpDown1.Value);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Minden mező kitöltése kötelező!", "Figyelem!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((TermekKategoria)comboBox1.SelectedIndex)
            {
                case TermekKategoria.Termék:
                    groupBox1.Visible = false;
                    break;
                case TermekKategoria.Tej:
                    groupBox1.Visible = true;
                    zsirtartalom_nu.Visible = true;
                    tejkategoria_cb.Visible = true;
                    teljeskiorlesu_check.Visible = false;
                    gyumolcs_check.Visible = false;
                    break;
                case TermekKategoria.Pékárú:
                    groupBox1.Visible = true;
                    zsirtartalom_nu.Visible = false;
                    tejkategoria_cb.Visible = false;
                    teljeskiorlesu_check.Visible = true;
                    gyumolcs_check.Visible = false;
                    break;
                case TermekKategoria.Zöldség:
                    groupBox1.Visible = true;
                    zsirtartalom_nu.Visible = false;
                    tejkategoria_cb.Visible = false;
                    teljeskiorlesu_check.Visible = false;
                    gyumolcs_check.Visible = true;
                    break;

            }
        }
    }
}
