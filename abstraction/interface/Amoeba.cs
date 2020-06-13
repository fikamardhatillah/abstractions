using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace abstraction.interface
{
    class Amoeba : IHewan
{
    public void Berkembangbiak()
    {
        Console.WriteLine("Amoeba berkembangbiak dengan cara membelah diri");
        Console.WriteLine("Dalam sekali berkembangbiak maka akan membelah dirinya menjadi dua bagian");
    }
}
}