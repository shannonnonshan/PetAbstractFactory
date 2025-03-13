using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Animal.Carnivore
{
    public class Cheetah : ICarnivore
    {
        public string GetName() => "Cheetah";
        public Image GetImage() => Image.FromFile("./images/cheetah.png");
    }
}
