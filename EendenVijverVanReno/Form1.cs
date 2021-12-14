using System;
using System.Windows.Forms;

namespace EendenVijverVanReno
{
    public partial class Form1 : Form
    {
        int timePassed = 0;
        int nextRandomAttack = 0;
        private Random rnd = new Random();
        Pond pond = new Pond();

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
                    pond.AddDuck("Duck " + i, Duck.duckGender.Male);
                }
                else
                {
                    pond.AddDuck("Duck " + i, Duck.duckGender.Female);
                }
                ltbDucks.Items.Add(pond.Ducks[i].ToString());
            }

            for (int i = 0; i < 5; i++)
            {
                int gender = rnd.Next(0, 3);
                if (gender == 0)
                {
                    pond.AddStork(Stork.storkGender.Male);
                }
                else if (gender == 1)
                {
                    pond.AddStork(Stork.storkGender.Female);
                }
                else
                {
                    pond.AddStork(Stork.storkGender.Other);
                }
                ltbStorks.Items.Add(pond.Storks[i].ToString());
            }
        }

        private void ltbDucks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbDucks.SelectedIndex != -1)
            {
                MessageBox.Show(pond.Ducks[ltbDucks.SelectedIndex].Sex.ToString());
            }
        }

        private void btnFrog_Click(object sender, EventArgs e)
        {
            int gender = rnd.Next(0, 3);

            if (gender == 0)
            {
                pond.AddFrog(Frog.frogGender.Male);
            }
            else if (gender == 1)
            {
                pond.AddFrog(Frog.frogGender.Female);
            }
            else
            {
                pond.AddFrog(Frog.frogGender.Other);
            }
            UpdateFrogsListBox();
        }

        private void tmrAttack_Tick(object sender, EventArgs e)
        {
            timePassed++;
            lblNextAttackSec.Text = (nextRandomAttack - timePassed).ToString();
            if (timePassed == nextRandomAttack)
            {
                if (pond.Frogs.Count != 0)
                {
                    int randomStork = rnd.Next(0, pond.Storks.Count -1);
                    int randomFrog = rnd.Next(0, pond.Frogs.Count - 1);

                    if (pond.Storks[randomStork].Sex.ToString() == pond.Frogs[randomFrog].Sex.ToString())
                    {
                        pond.Storks[randomStork].AttackFrog(pond.Frogs[randomFrog]);
                        MessageBox.Show(pond.Storks[randomStork].ToString() + "(" + pond.Storks[randomStork].Sex.ToString() + ") killed " + pond.Frogs[randomFrog] + "(" + pond.Frogs[randomFrog].Sex.ToString() + ")", "Success");
                        pond.Frogs.Remove(pond.Frogs[randomFrog]);
                        UpdateFrogsListBox();
                    }
                    else
                    {
                        MessageBox.Show(pond.Storks[randomStork].ToString() + "(" + pond.Storks[randomStork].Sex.ToString() + ") wanted to attack " + pond.Frogs[randomFrog] + "(" + pond.Frogs[randomFrog].Sex.ToString() + ")" + "\n" + "But failed because of gender" , "Error");
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
            foreach (var frog in pond.Frogs)
            {
                ltbFrog.Items.Add(frog.ToString());
            }
        }

        private void ltbStorks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbStorks.SelectedIndex != -1)
            {
                ltbKills.Items.Clear();
                if (pond.Storks[ltbStorks.SelectedIndex].EatenFrogs.Count != 0)
                {
                    foreach (var killedFrog in pond.Storks[ltbStorks.SelectedIndex].EatenFrogs)
                    {
                        ltbKills.Items.Add(killedFrog.ToString());
                    }
                }
            }
        }
    }
}
