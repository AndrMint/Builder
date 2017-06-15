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
    public partial class NaujasAuto : Form
    {
        public Automobilis Auto { get; private set; }
        public NaujasAuto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var marke = textBoxMarke.Text;
            var modelis = textBoxModelis.Text;
            var metai = Convert.ToInt32(textBoxMetai.Text);
            var darbinisTuris = Convert.ToDouble(textBoxDarbinisTuris.Text);
            var kuras = textBoxKuras.Text;

            Auto = new Automobilis(marke, modelis, metai, darbinisTuris, kuras);
        }
    }
}
