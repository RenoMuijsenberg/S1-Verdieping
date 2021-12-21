using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EendenVijverVanReno.Pond;

namespace EendenVijverVanReno
{
    class Stork
    {
        //Fields
        private readonly int storkId;
        private readonly string name;
        private readonly Genders sex;
        private static int nextStorkId = 0;
        private readonly List<Frog> eatenFrogs = new List<Frog>();
        
        //Constructor
        public Stork(Genders Sex)
        {
            storkId = nextStorkId;
            name = "Stork " + storkId;
            sex = Sex;
            nextStorkId++;
        }

        //Propertys
        public Genders Sex
        {
            get { return sex; }
        }

        public List<Frog> EatenFrogs
        {
            get { return eatenFrogs; }
        }

        //Methods
        public void AttackFrog(Frog eatenFrog)
        {
            eatenFrogs.Add(eatenFrog);
        }

        public override string ToString()
        {
            return name;
        }
    }
}
