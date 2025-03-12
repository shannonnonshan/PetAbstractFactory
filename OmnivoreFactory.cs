using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class OmnivoreFactory : IAnimalFactory
    {
        public IAnimal CreateHousePet() => new Parrot();
        public IAnimal CreateSmallWildAnimal() => new Squirrel();
        public IAnimal CreateDesertAnimal() => new Bear();
    }
}
