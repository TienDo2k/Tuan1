using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bangbam
{
    class Hashtb
    {
        public void nhap(Hashtable h)
        {
            Console.WriteLine("nhap key :");
            string k = Console.ReadLine();
            Console.WriteLine("nhap value :");
            string v = Console.ReadLine();
            h[k] = v;
        }
        public void print(Hashtable h)
        {
            foreach (DictionaryEntry item in h)
            {
                Console.WriteLine("{0}\t,\t{1}",  item.Key, item.Value);
            }
        }
        public void Insert(string s,Hashtable h)
        {
         
            foreach (DictionaryEntry item in h)
            {
                if (item.Key.Equals(s))
                    
                    Console.WriteLine( "Co ton tai phan tu voi key ={0} :\t\t ({1},{2}) " , item.Key,item.Key,item.Value);
            }
        }
    }
}

