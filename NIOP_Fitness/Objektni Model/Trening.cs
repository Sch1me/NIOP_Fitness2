using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIOP_Fitness.Objektni_Model
{
    internal class Trening : IComparable
    {
        Osoba osoba { get; set; }
        Vjezbe vjezbe { get; set; }
        public string opisTreninga { get; set; }
        public DateTime trajanjeTreninga { get; set; }
        public string nazivTreninga { get; set; }
        

        public override string ToString()
        {
            return "NAZIV TRENINGA - "+nazivTreninga+"\nOsoba: "+osoba+"\nOpis treninga: "+opisTreninga+"\nTrajanje Treninga: "+trajanjeTreninga;
        }

        public int CompareTo(object obj)
        {
            int rez = nazivTreninga.CompareTo(((Trening)obj).nazivTreninga);
            return rez;
        }


    }
}
