using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EendenVijverVanReno.Pond;

namespace EendenVijverVanReno
{
    class Duck
    {
        //Fields
        private readonly string name;
        private readonly Genders sex;

        //Constructor
        public Duck(string Name, Genders Sex)
        {
            name = Name;
            sex = Sex;
        }

        //Property
        public Genders Sex
        {
            get { return sex; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
