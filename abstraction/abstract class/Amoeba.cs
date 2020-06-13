using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace abstraction.abstract_class
{
    public abstract class Amoeba : Hewan
    {
        public override void Berkembangbiak()
        {
            Console.WriteLine("Amoeba berkembangbiak dengan cara membelah diri");
            Console.WriteLine("Dalam sekali berkembangbiak maka akan membelah dirinya menjadi dua bagian");
        }
    }
}
