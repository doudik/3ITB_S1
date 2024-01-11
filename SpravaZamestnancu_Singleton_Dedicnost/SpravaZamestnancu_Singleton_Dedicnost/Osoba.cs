using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaZamestnancu_Singleton_Dedicnost
{
    internal class Osoba
    {
        public string jmeno { get; private set; }
        public string prijmeni { get; private set; }
        public int vek { get; private set; }
        public string uid { get; protected set; }

        Random rnd = new Random();

        public Osoba(string jmeno, string prijmeni, int vek)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vek = vek;
            uid = VygenerujUID();
        }

        string VygenerujUID() {
            string uid = "";
            for (int i = 0; i < 10; i++)
            {
                uid += rnd.Next(0, 10).ToString();
            }
            return uid;
        }
        public virtual void VypisInformace() {
            Console.WriteLine($"{jmeno} {prijmeni} ve věku {vek} s uid: '{uid}'");
        }
    }
}
