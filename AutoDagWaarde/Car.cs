using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDagWaarde
{
    class Car
    {
        //Fields
        private int kilometer = 1;
        private readonly string kenteken;
        private brandstofType brandstof;

        public enum brandstofType
        {
            benzine = 100,
            diesel = 150,
            lpg = 90,
            elektrisch = 130

        }

        //Constructor
        public Car(string Kenteken, brandstofType Brandstof)
        {
            kenteken = Kenteken;
            brandstof = Brandstof;
        }

        //Property
        public int Kilometer 
        {
            get { return kilometer; }
        }

        public int DagWaarde
        {
            get { return (500000 / kilometer) * (int)brandstof; }
        }

        //Methods
        public void RijdKilometers(int gereden)
        {
            if (gereden > 0)
            {
                kilometer += gereden;
            }
        }

        public override string ToString()
        {
            return kenteken + ", " + brandstof + ", " + kilometer + " km gereden, Dagwaarde = " + DagWaarde;
        }
    }
}
