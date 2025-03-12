using System;

namespace AbstractFactory
{
	public interface IAnimalFactory
	{
        IAnimal CreateHousePet();
        IAnimal CreateSmallWildAnimal();
        IAnimal CreateDesertAnimal();
    }
}

