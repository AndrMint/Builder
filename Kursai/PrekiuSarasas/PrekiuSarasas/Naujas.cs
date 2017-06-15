using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrekiuSarasas
{
    public partial class Naujas : Form
    {
        public Preke NaujaPreke { get; private set; }

        public Naujas()
        {
            InitializeComponent();
        }

        private void buttonGerai_Click(object sender, EventArgs e)
        {
            var pavadinimas = textBox1.Text;
            var kodas = textBox2.Text;
            var kaina = Convert.ToDecimal(textBox3.Text);
            var savikaina = Convert.ToDecimal(textBox4.Text);

            NaujaPreke = new Preke(pavadinimas, kaina, kodas, savikaina);
        }
    }
}
