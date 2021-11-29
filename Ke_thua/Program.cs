using System;
using System.Text;

namespace Ke_thua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("------------Abstract-----------");
            Cho c1 = new Cho();
            Console.WriteLine("Thông tin của chó :\n \t\tMàu:{0},\n \t\tTiếng kêu :{1}", c1.getmau(), c1.getTiengkeu());
            Meo m1 = new Meo();
            Console.WriteLine("Thông tin của mèo :\n \t\tMàu:{0},\n \t\tTiếng kêu :{1}", m1.getmau(), m1.getTiengkeu());
            Console.WriteLine("\n \n------------Inerface-----------");
            dog d = new dog();
            cat c = new cat();
            d.Say();
            c.Say();
            Console.ReadKey();
        }
    }
}
