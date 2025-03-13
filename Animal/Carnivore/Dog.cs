using System;
namespace AbstractFactory.Animal.Carnivore
{
    public class Dog : ICarnivore

    {
        public string GetName() => "Dog";
        public Image GetImage() => Image.FromFile("./images/dog.png");
    }
}

