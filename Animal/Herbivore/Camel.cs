using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Animal.Herbivore
{
    public class Camel : IHerbivore
    {
        public string GetName() => "Camel";
        public string GetImage() => "";
    }
}
