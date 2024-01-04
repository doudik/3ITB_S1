using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Musicians
{
    internal class Slovo
    {
        public float vaha;
        public string text;

        Random rnd = new Random();

        public Slovo(string text)
        {
            vaha = rnd.Next();
            this.text = text;
        }
    }
}
