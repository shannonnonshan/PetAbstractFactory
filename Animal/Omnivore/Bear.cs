using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Animal.Omnivore
{
    public class Bear : IOmnivore
    {
        public string GetName() => "Bear";
        public Image GetImage() => Image.FromFile("./images/bear.png");
    }
}
