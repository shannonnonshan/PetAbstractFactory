using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Squirrel : IAnimal
    {
        public string GetName() => "Squirrel";
        public string GetImage() => "";
    }
}
