using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijverVanReno
{
    class Stork
    {
        //Fields
        private int storkId;
        private string name;
        private storkGender sex;
        private static int nextStorkId = 0;
        private List<Frog> eatenFrogs = new List<Frog>();
        
        public enum storkGender
        {
            Male,
            Female,
            Other
        }

        //Constructor
        public Stork(storkGender Sex)
        {
            storkId = nextStorkId;
            name = "Stork " + storkId;
            sex = Sex;
            nextStorkId++;
        }

        //Propertys
        public storkGender Sex
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
