using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaZamestnancu_Singleton_Dedicnost
{
    internal class Manazer : Osoba
    {
        List<Zamestnanec> seznamPodrizenych = new List<Zamestnanec>();

        public Manazer(string jmeno, string prijmeni, int vek) : base(jmeno, prijmeni, vek)
        {
            uid = "man_" + uid;
        }
        public void PridatPodrizeneho(Zamestnanec zamestnanec) {
            seznamPodrizenych.Add(zamestnanec);
        }
        public void OdebratPodrizeneho(Zamestnanec zamestnanec) {
            seznamPodrizenych.Remove(zamestnanec);
            //SpravaZamestnancu.spravaZamestnancu.OdeberZamestnance(zamestnanec);

        }
        public override void VypisInformace()
        {
            Console.Write("Manažer ");
            base.VypisInformace();

            Console.WriteLine("\nPodřízení:");
            foreach(Zamestnanec zamestnanec in seznamPodrizenych)
            {
                Console.Write(">\t");
                zamestnanec.VypisInformace(); //kontrola
            }
        }
    }
}
