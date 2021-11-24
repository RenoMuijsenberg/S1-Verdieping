using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AutoDagWaarde.Car;

namespace AutoDagWaarde
{
    public partial class Form1 : Form
    {
        int time = 0;
        int nextTime = 10;
        Random rnd = new Random();
        List<Car> cars = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cars.Add(new Car("AB-12-CD", Car.brandstofType.benzine));
            cars.Add(new Car("AB-22-CD", Car.brandstofType.elektrisch));
            cars.Add(new Car("AB-32-CD", Car.brandstofType.diesel));
            cars.Add(new Car("AB-42-CD", Car.brandstofType.lpg));
            tmrChange.Start();
            UpdateListbox();
        }

        private void tmrChange_Tick(object sender, EventArgs e)
        {
            if (time == nextTime)
            {
                nextTime += 10;
                for (int i = 0; i < 4; i++)
                {
                    if (cars[i].Kilometer < 10000)
                    {
                        cars[i].DriveKilometer(rnd.Next(1000, 2000));
                    }
                }
            }
            UpdateListbox();
            lblChange.Text = (nextTime - time).ToString();
            time++;
        }

        private void UpdateListbox()
        {
            ltbCars.Items.Clear();
            foreach (var car in cars)
            {
                ltbCars.Items.Add(car.ToString());
            }
        }
    }
}
