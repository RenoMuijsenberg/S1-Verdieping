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
                int gender = rnd.Next(0, 2);
                if (gender == 0)
                {
                    ducks.Add(new Duck("Duck " + i, Duck.duckGender.Male));
                }
                else
                {
                    ducks.Add(new Duck("Duck " + i, Duck.duckGender.Female));
                }
                ltbDucks.Items.Add(ducks[i].ToString());
            }

            for (int i = 0; i < 5; i++)
            {
                int gender = rnd.Next(0, 3);
                if (gender == 0)
                {
                    storks.Add(new Stork(Stork.storkGender.Male));
                }
                else if (gender == 1)
                {
                    storks.Add(new Stork(Stork.storkGender.Female));
                }
                else
                {
                    storks.Add(new Stork(Stork.storkGender.Other));
                }
                ltbStorks.Items.Add(storks[i].ToString());
            }
        }

        private void ltbDucks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbDucks.SelectedIndex != -1)
            {
                MessageBox.Show(ducks[ltbDucks.SelectedIndex].Sex.ToString());
            }
        }

        private void btnFrog_Click(object sender, EventArgs e)
        {
            int gender = rnd.Next(0, 3);

            if (gender == 0)
            {
                frogs.Add(new Frog(Frog.frogGender.Male));
            }
            else if (gender == 1)
            {
                frogs.Add(new Frog(Frog.frogGender.Female));
            }
            else
            {
                frogs.Add(new Frog(Frog.frogGender.Other));
            }
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

                    if (storks[randomStork].Sex.ToString() == frogs[randomFrog].FrogGender.ToString())
                    {
                        storks[randomStork].AttackFrog(frogs[randomFrog]);
                        MessageBox.Show(storks[randomStork].ToString() + "(" + storks[randomStork].Sex.ToString() + ") killed " + frogs[randomFrog] + "(" + frogs[randomFrog].FrogGender.ToString() + ")", "Success");
                        frogs.Remove(frogs[randomFrog]);
                        UpdateFrogsListBox();
                    }
                    else
                    {
                        MessageBox.Show(storks[randomStork].ToString() + "(" + storks[randomStork].Sex.ToString() + ") wanted to attack " + frogs[randomFrog] + "(" + frogs[randomFrog].FrogGender.ToString() + ")" + "\n" + "But failed because of gender" , "Error");
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
                if (storks[ltbStorks.SelectedIndex].EatenFrogs.Count != 0)
                {
                    foreach (var killedFrog in storks[ltbStorks.SelectedIndex].EatenFrogs)
                    {
                        ltbKills.Items.Add(killedFrog.ToString());
                    }
                }
            }
        }
    }
}
