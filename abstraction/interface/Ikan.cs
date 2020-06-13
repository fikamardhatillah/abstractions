using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction.interface
    {
    public class Ikan : IHewan
    {
        public override void Berkembangbiak()
         {
            Console.WriteLine("Ikan berkembangbiak dengan cara bertelur");
            Console.WriteLine("Dalam sekali bertelur biasanya menghasilkan lebih dari 500 telur");
         }

        public void berkembangbiak()
        {
            throw new NotImplementedException();
        }
    }
  
}
