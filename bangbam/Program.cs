using System;
using System.Collections;

namespace bangbam
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtb a = new Hashtb();
            string luaChon;
            Hashtable h = new Hashtable();
            h.Add("1", "java");
            h.Add("2", "python");
            h.Add("3", "hoa");
            do
            {
                Console.WriteLine("\nMAIN MENU: ");
                Console.WriteLine("\n1. Nhap cac cap key-value");
                Console.WriteLine("\n2. In Hashtable");
                Console.WriteLine("\n3. Tim kiem");
                Console.WriteLine("\nNhap vao lua chon cua ban: ");
                luaChon = Console.ReadLine();
                switch (luaChon)
                {
                    case "1":
                        a.nhap(h);
                        break;
                    case "2":
                        a.print(h);
                        break;
                    case "3":
                        {
                            Console.WriteLine("nhap Key can tim kiem :");
                            string s = Console.ReadLine();
                            a.Insert(s,h);
                        }
                        break;
                    default:
                        Console.WriteLine("\nNhap sai lua chon. Moi nhap lai");
                        break;
                }
            } 
            while (luaChon != "2");
             Console.ReadKey();

        }
    }
}
