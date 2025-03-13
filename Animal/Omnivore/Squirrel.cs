using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Animal.Omnivore
{
    public class Squirrel : IOmnivore
    {
        public string GetName() => "Squirrel";
        public Image GetImage() => Image.FromFile("./images/squirrel.png");
    }
}
