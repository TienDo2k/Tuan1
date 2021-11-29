using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_thua
{
   abstract class Inter
    {
        public abstract string tiengKeu();
        
    }
    class Dog : Inter
    {
        private string tieng;
        public void getTieng()
        {
            tieng = "gâu";
            
        }
        public override string tiengKeu()
        {
            return tieng;
        }
    }
    class Cat : Inter
    {
        private string tieng;
        public void getTieng()
        {
            tieng = "meo";

        }
        public override string tiengKeu()
        {
            return tieng;
        }
    }
}
