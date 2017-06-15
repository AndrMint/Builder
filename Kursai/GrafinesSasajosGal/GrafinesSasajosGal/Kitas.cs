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
    public partial class Kitas : Form
    {
        public Kitas(string kintamasis)
        {
            InitializeComponent();
            label1.Text = kintamasis;


        }

        private void Kitas_Load(object sender, EventArgs e)
        {

        }
    }
}
