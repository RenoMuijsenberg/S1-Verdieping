using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijverVanReno
{
    class Duck
    {
        //Fields
        private string name;
        private duckGender sex;

        public enum duckGender
        {
            Male,
            Female
        }

        //Constructor
        public Duck(string Name, duckGender Sex)
        {
            name = Name;
            sex = Sex;
        }

        //Property
        public duckGender Sex
        {
            get { return sex; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
