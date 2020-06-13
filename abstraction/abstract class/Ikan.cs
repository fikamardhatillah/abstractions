using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace abstraction.abstract_class
{
    public abstract class Ikan : Hewan
    {
        public override void Berkembangbiak()
        {
            Console.WriteLine("Ikan berkembangbiak dengan cara bertelur");
            Console.WriteLine("Dalam sekali bertelur biasanya menghasilkan lebih dari 500 telur");
        }
    }
}
