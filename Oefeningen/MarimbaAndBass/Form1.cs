using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarimbaAndBass
{
    public partial class Form1 : Form
    {
        Marimba marimba = new Marimba();
        Bass bass = new Bass();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMarimba_Click(object sender, EventArgs e)
        {
            marimba.PlayNote(txbMarimba.Text);
        }

        private void btnBass_Click(object sender, EventArgs e)
        {
            bass.PlayNote(txbBass.Text);
        }
    }
}
