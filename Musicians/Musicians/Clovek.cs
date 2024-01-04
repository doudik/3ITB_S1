using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicians
{
    internal class Clovek : ISkinColor
    {
        public string jmeno { get; private set; }
        public Genre zanr { get; private set; }
        public SkinColor skin { get; private set; }

        Random rnd = new Random();

        public Clovek(string jmeno) {
            this.jmeno = jmeno;
            skin = getSkinColor();
            zanr = getGenre();
        }

        public SkinColor getSkinColor()
        {
            return Enum.GetValues(typeof(SkinColor)).Cast<SkinColor>().ElementAt(rnd.Next(0, Enum.GetValues(typeof(SkinColor)).Length));
        }
        public Genre getGenre()
        {
            return Enum.GetValues(typeof(Genre)).Cast<Genre>().ElementAt(rnd.Next(0, Enum.GetValues(typeof(Genre)).Length));
        }
        public void Info() {
            Console.WriteLine($"Člověk {jmeno} barvy {skin} s žánrem {zanr}");
        }
    }
}
