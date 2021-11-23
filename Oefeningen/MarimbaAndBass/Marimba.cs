using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarimbaAndBass
{
    class Marimba
    {
        public void PlayNote(string note)
        {
            System.Windows.Forms.MessageBox.Show(note, "Marimba played");
        }
    }
}
