using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_thua
{
    class Ast
    {
        protected string tiengkeu;
        protected string maulong;
        public void keu(string k)
        {
            tiengkeu = k;
        }
        public void mau(string m)
        {
            maulong = m;
        }
    }
    class Cho : Ast
    {
        public string getTiengkeu()
        {
            tiengkeu = "go go go go";
            return tiengkeu;
        }
        public string getmau()
        {
            maulong = " đỏ ,vàng, đen";
            return maulong;
        }
    }

    class Meo : Ast
    {
        public string getTiengkeu()
        {
            tiengkeu = "meo meo ";
            return tiengkeu;
        }
        public string getmau()
        {
            maulong = "tam thể , trắng";
            return maulong;
        }
    }
}
