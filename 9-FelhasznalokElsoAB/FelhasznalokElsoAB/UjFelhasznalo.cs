using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelhasznalokElsoAB
{
    public partial class UjFelhasznalo : Form
    {
        SqlConnection connection;

        int id;

        public UjFelhasznalo(SqlConnection connection, int id = 0)
        {
            InitializeComponent();
            this.connection = connection;
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                try
                {
                    SqlCommand command =
                    new SqlCommand(
                        String.Format("INSERT INTO [Felhasznalo] ([Felhasznalonev], [Jelszo]) VALUES('{0}', '{1}')",
                            textBox1.Text, textBox2.Text), connection);
                    int erintettSorok = command.ExecuteNonQuery();
                    MessageBox.Show((erintettSorok == 1)
                        ? "A felhasználó hozzáadása sikeres volt"
                        : "A felhasználó hozzáadása sikertelen");
                    if (erintettSorok != 1)
                    {
                        DialogResult = DialogResult.None;
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("UNIQUE"))
                    {
                        MessageBox.Show("Már létező felhasználó!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.None;
                        ;
                    }
                }

            }
            else
            {
                try
                {
                    SqlCommand command = new SqlCommand(String.Format("UPDATE [Felhasznalo] SET [Felhasznalonev]='{0}', [Jelszo]='{1}' WHERE [Id]=" + id, textBox1.Text, textBox2.Text),connection);
                    int erintettSorok = command.ExecuteNonQuery();
                    MessageBox.Show((erintettSorok == 1)
                        ? "Felhasznaló módosítása sikeres volt"
                        : "A felhasználó nem módosúlt");
                    if (erintettSorok != 1)
                    {
                        DialogResult = DialogResult.None;
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("UNIQUE"))
                    {
                        MessageBox.Show("Már létező felhasználó!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.None;
                        ;
                    }
                }
            }
        }
    }
}
