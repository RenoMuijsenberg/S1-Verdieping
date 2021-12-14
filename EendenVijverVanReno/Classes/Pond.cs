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
        private List<Duck> ducks = new List<Duck>();
        private List<Frog> frogs = new List<Frog>();
        private List<Stork> storks = new List<Stork>();

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
        public void AddDuck(string name, Duck.duckGender sex)
        {
            ducks.Add(new Duck(name, sex));
        }

        public void AddFrog(Frog.frogGender sex)
        {
            frogs.Add(new Frog(sex));
        }

        public void AddStork(Stork.storkGender sex)
        {
            storks.Add(new Stork(sex));
        }
    }
}
