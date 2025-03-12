using System;
namespace AbstractFactory
{
    public class Dog : IAnimal
    {
        public string GetName() => "Dog";
        public string GetImage() => "";
    }
}

