using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace abstraction.interface
{
    class Kucing : IHewan
    {
        public void Berkembangbiak()
       {
           Console.WriteLine("Kucing beerkembangbiak dengan cara beranak");
           Console.WriteLine("Dalam sekali melahirkan biasanya menghasilkan 3 sampai 6 anak kucing");
       }
    }
}
