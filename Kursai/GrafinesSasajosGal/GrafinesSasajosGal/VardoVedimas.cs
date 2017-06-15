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
    public partial class VardoVedimas : Form
    {
        public string Vardas { get; private set; }

        public VardoVedimas()
        {
            InitializeComponent();
        }

        private void buttonGerai_Click(object sender, EventArgs e)
        {
            Vardas = textBox1.Text;
        }
    }
}
