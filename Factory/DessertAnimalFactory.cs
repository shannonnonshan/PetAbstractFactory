using AbstractFactory.Animal.Carnivore;
using AbstractFactory.Animal.Herbivore;
using AbstractFactory.Animal.Omnivore;
using AbstractFactory.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class DessertAnimalFactory : IAnimalFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Cheetah();
        }
        public IOmnivore CreateIOmnivore()
        {
            return new Bear();
        }
        public IHerbivore CreateHerbivore()
        {
            return new Camel();
        }
    }
}
