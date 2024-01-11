using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaZamestnancu_Singleton_Dedicnost
{
    internal sealed class SpravaZamestnancu
    {
        List<Osoba> seznamZamestnancu = new List<Osoba>();

        static SpravaZamestnancu instance = new SpravaZamestnancu();
        public static SpravaZamestnancu spravaZamestnancu { 
            get { return instance; } 
        }

        private SpravaZamestnancu() { }
        public void PridatZamestnance(Osoba osoba)
        {
            seznamZamestnancu.Add(osoba);
        }
        public void OdeberZamestnance(Osoba osoba)
        {
            seznamZamestnancu.Remove(osoba);
            foreach (Osoba item in seznamZamestnancu)
            {
                if (item is Manazer)
                {
                    ((Manazer)item).OdebratPodrizeneho((Zamestnanec)osoba);
                }
            }
        }

        public void VypisZamestnance()
        {
            foreach(Osoba osoba in seznamZamestnancu)
            {
                osoba.VypisInformace();
            }
        }
    }


}
