using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_text_overload
{
    class ArrayTypeOverload
    {
        private int[] our_array;

        public ArrayTypeOverload(int size, bool flag)
        {
            our_array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++) our_array[i] = rnd.Next(100);
        }

        public ArrayTypeOverload(int size)
        {
            our_array = new int[size];
        }

        public int[] getArray()
        {
            return our_array;
        }

        public static explicit operator string(ArrayTypeOverload s)
        {
            string answer = "";
            foreach (int e in s.getArray()) answer += e + " ";
            return answer;
        }

        public static explicit operator int(ArrayTypeOverload s)
        {
            int sum = 0;
            foreach (int e in s.getArray()) sum += e;
            return sum;
        }

        public static explicit operator ArrayTypeOverload(int s)
        {
            return new ArrayTypeOverload(s);
        }
    }
}
