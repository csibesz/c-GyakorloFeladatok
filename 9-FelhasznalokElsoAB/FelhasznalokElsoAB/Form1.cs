using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelhasznalokElsoAB
{
    public partial class Form1 : Form
    {
        SqlConnection connection;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           connection = new SqlConnection();
            connection.ConnectionString =
                ConfigurationManager.ConnectionStrings[
                    "FelhasznalokElsoAB.Properties.Settings.FelhasznalokElsoConnectionString"].ConnectionString;
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Rows.Clear();
            SqlCommand command = new SqlCommand("SELECT * FROM [Felhasznalo]", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (dataGridView1.Columns.Count == 0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }
                }
                dataGridView1.Rows.Add();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[i].Value = reader.GetValue(i);
                }
            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UjFelhasznalo dialogus = new UjFelhasznalo(connection);
            dialogus.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells != null && dataGridView1.SelectedCells[0].Value is int)
            {
                UjFelhasznalo dialogus = new UjFelhasznalo(connection, (int)dataGridView1.SelectedCells[0].Value);
                dialogus.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells != null && dataGridView1.SelectedCells[0].Value is int)
            {
                SqlCommand command = new SqlCommand("DELETE FROM [Felhasznalo] WHERE [Id]="+dataGridView1.SelectedCells[0].Value,connection);
                int erintettSorok = command.ExecuteNonQuery();
                MessageBox.Show("A törlés " + erintettSorok + " sort érintett!");
            }
        }
    }
}
