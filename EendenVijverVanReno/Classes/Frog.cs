using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EendenVijverVanReno.Pond;

namespace EendenVijverVanReno
{
    class Frog
    {
        //Fields
        private readonly int frogId;
        private readonly string name;
        private Genders sex;
        private static int nextFrogId = 0;

        //Constructor
        public Frog(Genders Sex)
        {
            frogId = nextFrogId;
            name = "Frog " + frogId;
            sex = Sex;
            nextFrogId++;
        }

        //Property
        public Genders Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
