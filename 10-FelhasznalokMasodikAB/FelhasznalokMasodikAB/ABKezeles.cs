using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FelhasznalokMasodikAB
{
    static class ABKezeles
    {
        static SqlConnection connection;
        static SqlCommand command;

        static ABKezeles()
        {
            connection = new SqlConnection();
            command = new SqlCommand();
            command.Connection = connection;
        }

        public static void Init(string conStr)
        {
            connection.ConnectionString = conStr;
            connection.Open();
        }

        public static void Kapcsolatbontas()
        {
            connection.Close();
        }

        public static List<Felhasznalo> Kiolvas()
        {
            List<Felhasznalo> felhasznalok = new List<Felhasznalo>();
            command.CommandText = "SELECT * FROM [Felhasznalo]";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    felhasznalok.Add(new Felhasznalo(
                        (int)reader["id"],
                        reader["Felhasznalonev"].ToString(),
                        reader["Jelszo"].ToString(),
                        DateTime.Parse(reader["RegisztracioIdeje"].ToString())
                        ));
                }
                reader.Close();
            }
            return felhasznalok;
        }

        public static void Kiolvas(ListView lw)
        {
            command.Parameters.Clear();
            command.CommandText = "SELECT * FROM [Felhasznalo]";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (lw.Columns.Count == 0)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            lw.Columns.Add(reader.GetName(i));
                        }
                    }
                    string[] adatok = new string[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        adatok[i] = reader.GetValue(i).ToString();
                    }
                    lw.Items.Add(new ListViewItem(adatok));
                }
                reader.Close();
            }
        }

        public static void Kiolvas(DataGridView dgv)
        {
            command.Parameters.Clear();
            command.CommandText = "SELECT * FROM [Felhasznalo]";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (dgv.Columns.Count == 0)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dgv.Columns.Add(reader.GetName(i), reader.GetName(i));
                        }
                    }
                    dgv.Rows.Add();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dgv.Rows[dgv.Rows.Count - 1].Cells[i].Value = reader.GetValue(i);
                    }
                }
                reader.Close();
            }
        }

        public static void Beszuras(Felhasznalo uj)
        {
            command.CommandText =
                "INSERT OUTPUT [Id] INTO [Felhasznalo]([Felhasznalonev],[Jelszo], [RegisztracioIdeje]) VALUES(@felhasznalo, @jelszo, @regisztracio)";
            command.Parameters.Add(new SqlParameter("@felhasznalo", uj.FelhasznaloNev));
            command.Parameters.Add(new SqlParameter("@jelszo", uj.Jelszo));
            command.Parameters.Add(new SqlParameter("@regisztracio", uj.RegisztracioIdeje));
            uj.Id = (int)command.ExecuteScalar();
        }

        public static void Modositas(Felhasznalo modosit)
        {
            command.CommandText = "UPDATE [Felhasznalo] SET [Jelszo] = @jelszo WHERE [Id] = @id";
            command.Parameters.Add(new SqlParameter("@jelszo", modosit.Jelszo));
            command.Parameters.Add(new SqlParameter("@id", modosit.Id));
            /*
             Az SQLCommand önmagában semmit sem csinál, azt futtatnunk kell
             comm.ExecuteNonQuery(); -> Végrehajtja a megadott SQL-t és viisszaadja hogy hány sor az érintett, az sql által
             comm.ExecuteReader(); -> Végrehajtja a megadott SQL -t, és visszaadja hogy az adott lekérdezés mit adott vissza (pl.: a SELECT utasításokhoz nagyon jol használható)
             comm.ExecuteScalar(); -> Végrehajtja a megadott SQLt, és visszaadja az első mezőnek a legelső értékét
             */
            command.ExecuteNonQuery();
        }

        public static Felhasznalo Beleptetes(string felhasznaloNev, string jelszo)
        {
            command.Parameters.Clear();
            command.CommandText =
                "SELECT * FROM [Felhasznalo] WHERE [Felhasznalonev] = @felhasznalo AND [Jelszo] = @jelszo";
            command.Parameters.AddWithValue("@felhasznalo", felhasznaloNev);
            command.Parameters.AddWithValue("@jelszo", jelszo);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new Felhasznalo(
                        (int)reader["Id"],
                        reader["Felhasznalonev"].ToString(),
                        reader["Jelszo"].ToString(),
                        DateTime.Parse(reader["RegisztracioIdeje"].ToString())
                        );
                }
                return null;
            }
        }

        public static void Torol(Felhasznalo torol)
        {
            command.Parameters.Clear();
            command.CommandText = "DELETE FROM [Felhasznalo] WHERE [Id] = @id";
            command.Parameters.AddWithValue("@id", torol.Id);
            command.ExecuteNonQuery();
        }
    }
}