using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtsitiktinisZodis
{
    public partial class Form1 : Form
    {

        private Random atsitiktinis;


        public Form1()
        {
            InitializeComponent();
            atsitiktinis = new Random();
        }

        private void buttonGerai_Click(object sender, EventArgs e)
        {
            var zodis = textBox1.Text; //paimu zodi
            if (!string.IsNullOrEmpty(zodis))
            {
                listBox1.Items.Add(zodis); //idedamas zodis
                textBox1.Text = "";
                var kelintas = Convert.ToInt32(toolStripStatusLabel2.Text);
                kelintas++;
                toolStripStatusLabel2.Text = kelintas.ToString();

            }
        }

        private void buttonAtsitiktinis_Click(object sender, EventArgs e)
        {
            var maksimaliReiksme = listBox1.Items.Count;
            var atsitiktinisZodis = atsitiktinis.Next(maksimaliReiksme);
            var zodis = listBox1.Items[atsitiktinisZodis];
            MessageBox.Show(zodis.ToString());
        }
    }
}
