using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijverVanReno
{
    class Stork
    {
        int storkId;
        string name;
        private Sex sex;
        private static int nextStorkId = 0;
        private List<Frog> eatenFrogs = new List<Frog>();
        
        private enum Sex
        {
            Male,
            Female,
            Other
        }

        public Stork(int randomSex)
        {
            storkId = nextStorkId;
            name = "Stork " + storkId;
            sex = (Sex)randomSex;
            nextStorkId++;
        }

        public void AttackFrog(Frog eatenFrog)
        {
            eatenFrogs.Add(eatenFrog);
        }

        public string GetSex()
        {
            return sex.ToString();
        }

        public List<Frog> GetKilledFrogs()
        {
            return eatenFrogs;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
