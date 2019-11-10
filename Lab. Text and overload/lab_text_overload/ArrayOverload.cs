using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_text_overload
{
    class ArrayOverload
    {

        private int[] our_array;

        public ArrayOverload(int n)
        {
            our_array = new int[n];
        }

        public ArrayOverload(int[] inp)
        {
            our_array = inp;
        }

        public ref int[] getArray()
        {
            return ref our_array;
        }

        public static string operator ~(ArrayOverload arr)
        {
            return String.Join(" ", arr.getArray());
        }

        public static ArrayOverload operator ++(ArrayOverload arr)
        {
            int[] temp = arr.getArray();
            Array.Resize(ref temp, temp.Length + 1);
            return new ArrayOverload(temp);
        }

        public static ArrayOverload operator --(ArrayOverload arr)
        {
            int[] temp = arr.getArray();
            Array.Resize(ref temp, temp.Length - 1);
            return new ArrayOverload(temp);
        }

        public static ArrayOverload operator +(ArrayOverload arr, ArrayOverload arr1)
        {
            int[] temp = arr.getArray();
            int[] temp1 = arr1.getArray();
            int[] answer = new int[temp.Length + temp1.Length];
            for (int i = 0; i < temp.Length; i++) answer[i] = temp[i];
            for (int i = 0; i < temp1.Length; i++) answer[i + temp.Length] = temp1[i];
            return new ArrayOverload(answer);
        }

        public static ArrayOverload operator +(ArrayOverload arr, int operand)
        {
            int[] temp = arr.getArray();
            Array.Resize(ref temp, temp.Length + 1);
            temp[temp.Length - 1] = operand;
            return new ArrayOverload(temp);
        }

        public static ArrayOverload operator +(int operand, ArrayOverload arr)
        {
            int[] temp = arr.getArray();
            Array.Resize(ref temp, temp.Length + 1);
            temp[temp.Length - 1] = operand;
            return new ArrayOverload(temp);
        }
    }
}
