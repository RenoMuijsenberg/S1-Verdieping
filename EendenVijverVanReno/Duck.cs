using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijverVanReno
{
    class Duck
    {
        string name;
        private Sex sex;
        private enum Sex
        {
            Male,
            Female
        }

        public Duck(string duckName, int randomSex)
        {
            name = duckName;
            sex = (Sex)randomSex;
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
