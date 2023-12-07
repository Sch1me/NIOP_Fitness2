using NIOP_Fitness.Forme;
using NIOP_Fitness.Objektni_Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIOP_Fitness
{
    internal class PodatkovniKontekst
    {

        public List<OsobaModel> osobe;
        public List<VjezbeModel> vjezbe;
        public List<TreningModel> treninzi;
        public List<String> linijaVjezbe;
        private void main(string[] args)
        {
            
        }
//funkcije koje koristimo za ubacivanje novih vjezbi i osoba
        public void DodavanjeVjezbe(String vjezba1)
        {
            StreamWriter streamWriterVjezbe = new StreamWriter("Popis Vjezbi.txt");
            streamWriterVjezbe.WriteLine(vjezba1);
            streamWriterVjezbe.Close();
        }
        public void DodavanjeOsobe(OsobaModel osoba1)
        {

            StreamWriter streamWriterOsoba = new StreamWriter("Popis Osoba.txt");
            streamWriterOsoba.WriteLine(osoba1);
            streamWriterOsoba.Close();
        }
        public void DodavanjeTreninga()
        {
            //upitno kako napraviti
        }
        public void CitanjeVjezbe()
        {
            int i = 0;
            String popisVjezbi;
            StreamReader streamReaderVjezbe = new StreamReader("Popis Vjezbi.txt");
            while (streamReaderVjezbe != null) { 
                
                popisVjezbi = streamReaderVjezbe.ReadLine();
                linijaVjezbe.Add(popisVjezbi);

            }
        }

    }
    
}
