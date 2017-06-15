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

namespace ZodziuSarasas
{
    public partial class MainForm : Form
    {
        public string ConnectionString { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            ConnectionString = "Data Source=Pradzia.db; Version = 3;";
            using (var con = new SQLiteConnection(ConnectionString))
            {
                con.Open();

                var sql = "select * from zodziai";
                var cmd = new SQLiteCommand(sql, con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listBox1.Items.Add(reader["zodis"]);
                }

                toolStripStatusLabel1.Text = "Zodziu sarase: " + listBox1.Items.Count;

                con.Close();
            }
        }

        private void iseitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void naujasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Naujas forma = new Naujas())
            {
               {
                    forma.ShowDialog();
                    if (forma.DialogResult == DialogResult.OK)
                    {
                        var zodis = forma.Zodis;
                        listBox1.Items.Add(zodis);
                        using (var con = new SQLiteConnection(ConnectionString))
                        {
                            con.Open();
                            /*
                            if (con.State == ConnectionState.Open)
                            {
                                MessageBox.Show("Prisijungti pavyko");
                            }
                            */

                            var sql = "insert into zodziai (zodis) values ('" + zodis + "')";
                            var cmd = new SQLiteCommand(sql, con);
                            cmd.ExecuteNonQuery();

                            con.Close();
                        }
                            toolStripStatusLabel1.Text = "Zodziu sarase: " + listBox1.Items.Count;
                    }

                }
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
