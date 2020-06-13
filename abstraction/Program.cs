using System;
using abstraction.abstract_class;

namespace abstraction
{
    class Program
    {
        static void Main(string[] args, object hewan)
        {
            Console.WriteLine("\n\t Menggunakan abstraction class\n");
            Hewan hewan = new Kucing();
            new Kucing.Berkembangbiak();
            hewan = new Ikan();
            new Ikan.Berkembangbiak();
            hewan = new Amoeba();
            new Amoeba.Berkembangbiak();

            IHewan ihewan;
            Console.WriteLine("\n\t Menggunakan Interface\n");
            ihewan = new Kucing();
            ihewan.Berkembangbiak();
            ihewan = new Ikan();
            ihewan.Berkembangbiak();
            ihewan = new Amoeba();
            ihewan.Berkembangbiak();
            ihewan.Lain();

            Console.ReadKey();
        }
    }
}
