using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Parrot : IAnimal
    {
        public string GetName() => "Bear";
        public string GetImage() => "";
    }
}
