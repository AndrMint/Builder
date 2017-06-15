using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZodziuSarasas
{
    public partial class Naujas : Form
    {
        public string Zodis { get; private set; }

        public Naujas()
        {
            InitializeComponent();
        }

        private void buttonGerai_Click(object sender, EventArgs e)
        {
            Zodis = textBox1.Text;
        }
    }
}
