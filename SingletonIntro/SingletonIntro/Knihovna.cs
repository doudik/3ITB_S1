using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonIntro
{
    internal class Knihovna
    {
        public List<Kniha> knihy { get; private set; } = new List<Kniha>();
        public string nazevKnihovny { get; private set; }

        public Knihovna(string nazevKnihovny)
        {
            this.nazevKnihovny = nazevKnihovny;
        }
        protected void PridatKnihu(Kniha kniha)
        {
            knihy.Add(kniha);
        }
        protected void OdstranitKnihu(Kniha kniha) { 
            knihy.Remove(kniha);
        }
        protected void VypisVsechKnih() {
            foreach (var item in knihy)
            {
                Console.WriteLine($"Název knihy: {item.nazevKnihy} | autor: {item.autorKnihy}");
            }
        }

    }
}
