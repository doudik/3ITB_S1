using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite2
{
    internal class AnimalGroup
    {
        List<IAnimal> animals = new List<IAnimal>();

        public void Add(IAnimal animal)
        {
            animals.Add(animal);
        }

        public void Output() {
            foreach (var item in animals)
            {
                item.Eat();
                item.Sleep();
            }
        }

    }
}
