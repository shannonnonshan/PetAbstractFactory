using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Animal.Herbivore
{
    public class Deer : IHerbivore
    {
        public string GetName() => "Deer";
        public string GetImage() => "";
    }
}
