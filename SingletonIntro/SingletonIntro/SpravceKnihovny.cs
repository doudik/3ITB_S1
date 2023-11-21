using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonIntro
{
    internal sealed class SpravceKnihovny : Knihovna
    {
        static string jmeno { get; } = "Karel";
        static SpravceKnihovny spravce = new SpravceKnihovny("");

        //Privátní konstruktor
        private SpravceKnihovny(string nazevKnihovny) : base(nazevKnihovny) { }

        public static SpravceKnihovny VratSpravce()
        {
            return spravce;
        }

        public void PridejKnihuDoSbirky(Kniha kniha)
        {
            PridatKnihu(kniha);
        }

        public void OdeberKnihuZeSbirky(Kniha kniha)
        {
           OdstranitKnihu(kniha);
        }
        public void VypisVsechnyKnihy() {
            VypisVsechKnih();
        }

    }
}
