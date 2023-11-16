using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Cat : IAnimal
    {
        public string name { get; private set; }

        public Cat(string name)
        {
            this.name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("Mňau");
        }
    }
}
