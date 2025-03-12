using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Animal.Herbivore
{
    public class Rabbit : IHerbivore
    {
        public string GetName() => "Rabbit";
        public string GetImage() => "";
    }
}
