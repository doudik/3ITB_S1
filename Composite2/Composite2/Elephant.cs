using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite2
{
    public class Elephant : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Slon se najedl");
        }

        public void Sleep()
        {
            Console.WriteLine("Slon si stoupl ke spánku.");
        }
    }
}
