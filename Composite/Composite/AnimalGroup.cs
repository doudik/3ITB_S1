using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class AnimalGroup : IAnimal
    {
        public List<IAnimal> animals { get; private set; } = new List<IAnimal>();
        
        public void MakeSound()
        {
            foreach (var item in animals)
            {
                item.MakeSound();
            }
        }
        public List<IAnimal> ReturnList() {
            return animals;
        }
        public void RegisterAnimalToGroup(IAnimal animal) {
            animals.Add(animal);   
        }
        public void RemoveAnimalFromGroup(IAnimal animal) {
            animals.Remove(animal);
        }
    }
}
