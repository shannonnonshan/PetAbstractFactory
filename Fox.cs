using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Fox : IAnimal
    {
        public string GetName() => "Fox";
        public string GetImage() => "";
    }
}
