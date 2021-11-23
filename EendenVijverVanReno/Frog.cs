using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijverVanReno
{
    class Frog
    {
        int frogId;
        string name;
        private Sex sex;
        static int nextFrogId = 0;

        private enum Sex
        {
            Male,
            Female,
            Other
        }

        public Frog(int randomSex)
        {
            frogId = nextFrogId;
            name = "Frog " + frogId;
            sex = (Sex)randomSex;
            nextFrogId++;
        }

        public string GetSex()
        {
            return sex.ToString();
        }

        public override string ToString()
        {
            return name;
        }
    }
}
