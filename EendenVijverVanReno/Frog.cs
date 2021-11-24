using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijverVanReno
{
    class Frog
    {
        //Fields
        private int frogId;
        private string name;
        private frogGender sex;
        private static int nextFrogId = 0;
        public enum frogGender
        {
            Male,
            Female,
            Other
        }

        //Constructor
        public Frog(frogGender Sex)
        {
            frogId = nextFrogId;
            name = "Frog " + frogId;
            sex = Sex;
            nextFrogId++;
        }

        //Property
        public frogGender FrogGender
        {
            get { return sex; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
