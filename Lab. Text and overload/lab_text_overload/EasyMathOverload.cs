using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_text_overload
{
    class EasyMathOverload
    {

        private int field;

        public EasyMathOverload(int n)
        {
            field = n;
        }

        public int getNum()
        {
            return field;
        }

        public static bool operator true(EasyMathOverload a)
        {
            int temp = a.getNum();
            if (temp == 2 || temp == 3 || temp == 5 || temp == 7) return true; else return false;
        }

        public static bool operator false(EasyMathOverload a)
        {
            int temp = a.getNum();
            if (temp != 2 && temp != 3 && temp != 5 && temp != 7) return true; else return false;
        }
        public static bool operator &(EasyMathOverload a, EasyMathOverload b)
        {
            if (a)
            {
                if (b) return true; else return false;
            }
            else return false;
        }

        public static bool operator |(EasyMathOverload a, EasyMathOverload b)
        {
            if (a) return true;
            if (b) return true;
            return false;
        }
    }
}
