using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PrekiuSarasas
{
    public partial class MainForm : Form
    {
        public List<Preke> Prekes { get; private set; }
        public string ConnectionString { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            Prekes = new List<Preke>();
            ConnectionString = "Data Source = Prekes.db; Version = 3;";


            using(var con = new SQLiteConnection(ConnectionString))
            {
                con.Open();

                var sql = "select * from prekes";
                var cmd = new SQLiteCommand(sql, con);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var pavadinimas = reader["pavadinimas"].ToString();
                    var kodas = reader["kodas"].ToString();


                    var kaina = Convert.ToDecimal(reader["kaina"]);
                    var savikaina = Convert.ToDecimal(reader["savikaina"]);
                    var preke = new Preke(pavadinimas, kaina, kodas, savikaina);

                    Prekes.Add(preke);
                }
                dataGridView1.DataSource = Prekes;
                toolStripStatusLabel1.Text = "Zodziu sarase: " + Prekes.Count;


                con.Close();
            }
        }

        private void iseitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void naujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var forma = new Naujas())
            {
                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {
                    Prekes.Add(forma.NaujaPreke);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Prekes;

                    using (var con = new SQLiteConnection(ConnectionString))
                    {
                        con.Open();
                        /*
                        if (con.State == ConnectionState.Open)
                        {
                            MessageBox.Show("shit");
                        }*/

                        var sql = "insert into prekes (pavadinimas, kodas, kaina, savikaina) values ('" 
                            + forma.NaujaPreke.Pavadinimas
                            + "','"
                            + forma.NaujaPreke.Kodas
                            + "','"
                            + forma.NaujaPreke.Kaina
                            + "','"
                            + forma.NaujaPreke.Savikaina + "')";

                        var cmd = new SQLiteCommand(sql, con);
                        cmd.ExecuteNonQuery();

                        con.Close();
                    }
                    toolStripStatusLabel1.Text = "Zodziu sarase: " + Prekes.Count;
                }
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
