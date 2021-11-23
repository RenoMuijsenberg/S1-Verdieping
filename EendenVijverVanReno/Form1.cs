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
        int timePassed = 0;
        int nextRandomAttack = 0;
        private Random rnd = new Random();
        private List<Duck> ducks = new List<Duck>();
        private List<Frog> frogs = new List<Frog>();
        private List<Stork> storks = new List<Stork>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrAttack.Start();
            nextRandomAttack = rnd.Next(10, 25);
            for (int i = 0; i < 26; i++)
            {
                ducks.Add(new Duck("Duck " + i , rnd.Next(0, 2)));
                ltbDucks.Items.Add(ducks[i].ToString());
            }

            for (int i = 0; i < 5; i++)
            {
                storks.Add(new Stork(rnd.Next(0, 3)));
                ltbStorks.Items.Add(storks[i].ToString());
            }
        }

        private void ltbDucks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbDucks.SelectedIndex != -1)
            {
                MessageBox.Show(ducks[ltbDucks.SelectedIndex].GetSex());
            }
        }

        private void btnFrog_Click(object sender, EventArgs e)
        {
            frogs.Add(new Frog(rnd.Next(0, 2)));
            UpdateFrogsListBox();
        }

        private void tmrAttack_Tick(object sender, EventArgs e)
        {
            timePassed++;
            lblNextAttackSec.Text = (nextRandomAttack - timePassed).ToString();
            if (timePassed == nextRandomAttack)
            {
                if (frogs.Count != 0)
                {
                    int randomStork = rnd.Next(0, storks.Count -1);
                    int randomFrog = rnd.Next(0, frogs.Count - 1);

                    if (storks[randomStork].GetSex() == frogs[randomFrog].GetSex())
                    {
                        storks[randomStork].AttackFrog(frogs[randomFrog]);
                        MessageBox.Show(storks[randomStork].ToString() + "(" + storks[randomStork].GetSex() + ") killed " + frogs[randomFrog] + "(" + frogs[randomFrog].GetSex() + ")", "Success");
                        frogs.Remove(frogs[randomFrog]);
                        UpdateFrogsListBox();
                    }
                    else
                    {
                        MessageBox.Show(storks[randomStork].ToString() + "(" + storks[randomStork].GetSex() + ") wanted to attack " + frogs[randomFrog] + "(" + frogs[randomFrog].GetSex() + ")" + "\n" + "But failed because of gender" , "Error");
                    }
                }
                else
                {
                    MessageBox.Show("No frogs to attack", "Error");
                }
                nextRandomAttack += rnd.Next(10, 25);
            }
        }

        private void UpdateFrogsListBox()
        {
            ltbFrog.Items.Clear();
            foreach (var frog in frogs)
            {
                ltbFrog.Items.Add(frog.ToString());
            }
        }

        private void ltbStorks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbStorks.SelectedIndex != -1)
            {
                ltbKills.Items.Clear();
                if (storks[ltbStorks.SelectedIndex].GetKilledFrogs().Count != 0)
                {
                    foreach (var killedFrog in storks[ltbStorks.SelectedIndex].GetKilledFrogs())
                    {
                        ltbKills.Items.Add(killedFrog.ToString());
                    }
                }
            }
        }
    }
}
