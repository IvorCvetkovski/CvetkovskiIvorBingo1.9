using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvetkovskiIvorBingo
{
    class Listic
    {
        public static int brojac;
        int[] brojevi = new int[6];
        int[] dobitniListic = new int[6];

        public int[] GetDobitniListic()
        {
            return dobitniListic;
        }

        public void SetDobitniListic(int[] value)
        {
            dobitniListic = value;
        }

        public int[] GetBrojevi()
        {
            return brojevi;
        }

        public void SetBrojevi(int[] value)
        {
            brojevi = value;
        }

        public Listic(int[] brojevi)
        {
            this.brojevi = brojevi;
            brojac++;
        }

        public Listic()
        {
        }

        
    }
}
