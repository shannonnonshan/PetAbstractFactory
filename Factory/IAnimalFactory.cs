using System;
using AbstractFactory.Animal;

namespace AbstractFactory.Factory
{
    public interface IAnimalFactory
    {
        ICarnivore CreateCarnivore();
        IOmnivore CreateIOmnivore();
        IHerbivore CreateHerbivore();
    }
}

