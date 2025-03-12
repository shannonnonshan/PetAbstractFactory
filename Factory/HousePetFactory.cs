using AbstractFactory.Animal;
using AbstractFactory.Animal.Carnivore;
using AbstractFactory.Animal.Herbivore;
using AbstractFactory.Animal.Omnivore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class HousePetFactory: IAnimalFactory
    {
        public ICarnivore CreateCarnivore() 
        {
            return new Dog();
        }
        public IOmnivore CreateIOmnivore()
        {
            return new Parrot();
        }
        public IHerbivore CreateHerbivore()
        {
            return new Rabbit();
        }
    }
}
