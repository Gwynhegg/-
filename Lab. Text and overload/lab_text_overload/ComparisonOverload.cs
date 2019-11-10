using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_text_overload
{
    class ComparisonOverload
    {
        private int first_field;
        private int second_field;

        public ComparisonOverload(int a, int b)
        {
            first_field = a;
            second_field = b;
        }

        public int getQuad()
        {
            return (int)(Math.Pow(first_field, 2) + Math.Pow(second_field, 2));
        }

        public static bool operator <(ComparisonOverload a,ComparisonOverload b)
        {
            if (a.getQuad() < b.getQuad()) return true; else return false;
        }

        public static bool operator >(ComparisonOverload a, ComparisonOverload b)
        {
            if (a.getQuad() > b.getQuad()) return true; else return false;
        }
    }
}
