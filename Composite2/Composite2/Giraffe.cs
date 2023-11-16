using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite2
{
    internal class Giraffe : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Žirafa papká listy.");
        }

        public void Sleep()
        {
            Console.WriteLine("Žirafě padá krk. Zzz");
        }
    }
}
