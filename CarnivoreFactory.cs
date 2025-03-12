using System;
namespace AbstractFactory
{
    public class CarnivoreFactory : IAnimalFactory
    {
        public IAnimal CreateHousePet() => new Dog();
        public IAnimal CreateSmallWildAnimal() => new Fox();
        public IAnimal CreateDesertAnimal() => new Cheetah();
    }
}

