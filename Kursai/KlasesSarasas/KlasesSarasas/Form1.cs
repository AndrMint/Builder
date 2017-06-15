using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasesSarasas
{
    public partial class Form1 : Form
    {
        public List<Automobilis> Automobiliai { get; }

        public Form1()
        {
            InitializeComponent();
            Automobiliai = new List<Automobilis>()
            {
                new Automobilis("toyota", "3a1", 2014, 21, "Benzinas"),
                new Automobilis("audi", "a6", 2017, 29, "vanduo"),
                new Automobilis("daed", "paper", 2009, 11, "dujos"),
                new Automobilis("mitsubishi", "a5c", 1990, 30, "Benzinas"),
            };

            /*DataTable lentele = new DataTable();
            lentele.Columns.Add(new DataColumn("Modelis", typeof(string)));
            lentele.Columns.Add(new DataColumn("Marke", typeof(string)));
            lentele.Columns.Add(new DataColumn("Metai", typeof(int)));
            lentele.Columns.Add(new DataColumn("Darbinis turis", typeof(double)));
            lentele.Columns.Add(new DataColumn("Kuro tipas", typeof(string)));

            foreach (var auto in Automobiliai)
            {
                lentele.Rows.Add(auto.Marke, auto.Modelis, auto.Metai,
                    auto.DarbinisTuris, auto.KuroTipas); *
            }

            dataGridView1.DataSource = lentele;*/

            dataGridView1.DataSource = Automobiliai;
        }


        private void iseitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void naujasAutomobilisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var forma = new NaujasAuto())
            {
                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {
                    Automobiliai.Add(forma.Auto);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Automobiliai;
                }
            }
        }

        private void skaiciavimaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new Skaiciavimai(Automobiliai);
            forma.ShowDialog();
        }
    }
}
