using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonIntro
{
    internal class Kniha
    {
        public string nazevKnihy { get; private set; }
        public string autorKnihy { get; private set; }

        public Kniha(string nazevKnihy, string autorKnihy)
        {
            this.nazevKnihy = nazevKnihy;
            this.autorKnihy = autorKnihy;
        }   
    }
}
