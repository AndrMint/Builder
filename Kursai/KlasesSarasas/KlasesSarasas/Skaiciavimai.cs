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
    public partial class Skaiciavimai : Form
    {
        private Random atsitiktinis;

        public List<Automobilis> Automobiliai { get; }

        public Skaiciavimai(List<Automobilis> automobiliai)
        {
            InitializeComponent();
            Automobiliai = automobiliai;
            SeniausiasAutomobilis();
            NaujausiasAutomobilis();
            TurioVidurkis();
        }

        public Skaiciavimai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void SeniausiasAutomobilis()
        {
            var seniausias = Automobiliai[0].Metai;

            foreach (var auto in Automobiliai)
            {
                if (auto.Metai < seniausias)
                {
                    seniausias = auto.Metai;
                }
            }
            label1.Text = "Seniausio metai:";
            textBox1.Text = seniausias.ToString();
        }

        private void NaujausiasAutomobilis()
        {
            var naujausias = Automobiliai[0].Metai;

            foreach (var auto in Automobiliai)
            {
                if (auto.Metai > naujausias)
                {
                    naujausias = auto.Metai;
                }
            }
            label2.Text = "Naujausio metai:";
            textBox2.Text = naujausias.ToString();
        }

        private void TurioVidurkis()
        {
            var vidurkis = 0.0;

            foreach (var auto in Automobiliai)
            {
                
                    vidurkis += auto.DarbinisTuris;
                
            }

            var Atsakymas = vidurkis / Automobiliai.Count;
            label3.Text = "Vidurkis turio:";
            textBox3.Text = Atsakymas.ToString();
        }

        private void buttonAtsitiktinis_Click(object sender, EventArgs e)
        {
            var maksimaliReiksme = dataGridView1.Items.Count;
            var atsitiktinisZodis = atsitiktinis.Next(maksimaliReiksme);
            var zodis = dataGridView1.Items[atsitiktinisZodis];
            MessageBox.Show(zodis.ToString());
        }








        //metodai skaiciavimo

        //rezultatu isvedimas:
        //textBox1.Text = reiksme / atsakymas
    }
    }
