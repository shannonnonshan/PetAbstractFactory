using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Animal.Carnivore
{
    public class Fox : ICarnivore
    {
        public string GetName() => "Fox";
        public string GetImage() => "";
    }
}
