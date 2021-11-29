using System;

namespace Tuan1
{
    class Program
    {

        static void Main(string[] args)
        {
                    Console.WriteLine("--------- thực hiện bài toán với mảng ----------");
                    Console.WriteLine("nhap so phan tu mang :");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] a = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        a[i] = i;
                    }
                    Console.WriteLine(" In ra so nguyen to :");
                    SoNt s = new SoNt();
                    s.InSnt(a);
                    Console.ReadKey();
        }
    }
}
