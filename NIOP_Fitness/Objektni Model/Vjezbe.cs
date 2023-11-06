using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace NIOP_Fitness.Objektni_Model
{
    internal class Vjezbe:IComparable
    {
        public string imeVjezbe { get; set; }
        public int brojPonavljanja { get; set; }
        public int brojSerija { get; set; }
        public string vrstaVjezbe { get; set; }



        public override string ToString()
        {
            return "Naziv Vjezbe: " + imeVjezbe + "\nVrsta vjezbe: " + vrstaVjezbe;
        }

        public int CompareTo(object obj)
        {
            int rez = this.vrstaVjezbe.CompareTo(((Vjezbe)obj).vrstaVjezbe);
            if (rez == 0)
            {
                rez = this.imeVjezbe.CompareTo(((Vjezbe)obj).imeVjezbe);
                return rez;
            }
            else
            {
                return rez;
            }

        }
    }
}
