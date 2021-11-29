using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1
{
    class SoNt
    {
        public bool Sont(int n)
        {
            
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            return true;
        }
        public void InSnt( int[] a)
        {
            foreach(int i in a)
            {
                if (Sont(a[i]))
                    Console.WriteLine( a[i]);
            }

        }
    }
}
