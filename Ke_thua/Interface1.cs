using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_thua
{
    interface Interface1
     
    {
        void Say(); // phuong thuc interface khong co body
    }

    // dog "implements" interface IAnimal
    class dog : Interface1
    {
        public void Say()
        {
            // Cung cap than ham Say() o day
            Console.WriteLine("The dg says: gooooooo");
        }
    }
    class cat : Interface1
    {
        public void Say()
        {
            // Cung cap than ham Say() o day
            Console.WriteLine("The dg says: meoooo");
        }
    }

}

