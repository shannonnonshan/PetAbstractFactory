using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Animal.Omnivore
{
    public class Parrot : IOmnivore
    {
        public string GetName() => "Parrot";
        public Image GetImage() => Image.FromFile("./images/parrot.png");
    }
}
