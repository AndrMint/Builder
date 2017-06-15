using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafinesSasajosGal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KeistiTeksta_Click(object sender, EventArgs e)
        {
            label1.Text = "Naujas tekstas";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sveiki visi");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pirmas = Convert.ToInt32(textBoxPirmas.Text);
            var antras = Convert.ToInt32(textBoxAntras.Text);
            textBoxPirmas.Text = "";
            textBoxAntras.Text = "";
            var atsakymas = pirmas + antras;
            MessageBox.Show(atsakymas.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kitas forma = new Kitas("Perduodamas kintamasis");
            forma.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var forma = new VardoVedimas())
            {
                forma.ShowDialog();
                if (forma.DialogResult == DialogResult.OK)
                {
                    labelVardas.Text = "Ivestas vardas: " + forma.Vardas;
                }
            }
        }
    }
}
