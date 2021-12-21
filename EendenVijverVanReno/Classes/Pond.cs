using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijverVanReno
{
    class Pond
    {
        //Fields
        private readonly List<Duck> ducks = new List<Duck>();
        private readonly List<Frog> frogs = new List<Frog>();
        private readonly List<Stork> storks = new List<Stork>();

        public enum Genders
        {
            Male,
            Female,
            Other
        }

        //Property
        public List<Duck> Ducks
        {
            get { return ducks; }
        }

        public List<Frog> Frogs 
        {
            get { return frogs; }
        }

        public List<Stork> Storks
        {
            get { return storks; }
        }

        //Methods
        public void AddDuck(string name, Genders sex)
        {
            ducks.Add(new Duck(name, sex));
        }

        public void AddFrog(Genders sex)
        {
            frogs.Add(new Frog(sex));
        }

        public void AddStork(Genders sex)
        {
            storks.Add(new Stork(sex));
        }
    }
}
