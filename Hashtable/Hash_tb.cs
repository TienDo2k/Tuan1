using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Hashtable1
{
    class Hash_tb

    {
        Hashtable h = new Hashtable();
        public void nhap()
        {
            h.Add("001", "java");
            int luachon = 0;
            Console.WriteLine("Vui long lua chon : \n 1 : them gia tri \n phim bat ky de dung lai ");
            switch (luachon)
            {
                case 1:
                    Console.WriteLine("nhap key :");
                    string k = Console.ReadLine();
                    Console.WriteLine("nhap value :");
                    string v = Console.ReadLine();
                    h.Add(k, v); break;
                default: break;
            }
        }
        public string Insert()
        {

            string s = Console.ReadLine();
            if (h.ContainsKey(s))
                return "Tồn tại trong hashtable";
            return "Không tồn tại ";
        }
    }
}
