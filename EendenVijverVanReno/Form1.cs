using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EendenVijverVanReno
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private List<Duck> ducks = new List<Duck>();
        private List<Frog> frogs = new List<Frog>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 26; i++)
            {
                ducks.Add(new Duck("Duck " + i , rnd.Next(0, 2)));
                ltbDucks.Items.Add(ducks[i].ToString());
            }
        }

        private void ltbDucks_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(ducks[ltbDucks.SelectedIndex].GetSex());
        }

        private void btnFrog_Click(object sender, EventArgs e)
        {
            frogs.Add(new Frog(rnd.Next(0, 2)));
            ltbFrog.Items.Clear();
            foreach (var frog in frogs)
            {
                ltbFrog.Items.Add(frog.ToString());
            }
        }
    }
}
