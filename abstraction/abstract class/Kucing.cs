using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace abstraction.abstract_class
{
    public abstract class Kucing : Hewan
    {
        public override void Berkembangbiak()
        {
            Console.WriteLine("Kucing beerkembangbiak dengan cara beranak");
            Console.WriteLine("Dalam sekali melahirkan biasanya menghasilkan 3 sampai 6 anak kucing");
        }

            
    }
}
