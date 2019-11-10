using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_text_overload
{
    class ArrayWork
    {
        private int[] our_array;

        public ArrayWork(int n)
        {
            our_array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++) our_array[i] = rnd.Next(100);
        }

        public override string ToString()
        {
            string output = String.Join(" ", our_array);
            output += '\n' + "Number of Elements: " + our_array.Length+'\n';
            double average = 0;
            for (int i = 0; i < our_array.Length; i++) average += our_array[i];
            output += "Average: " + (average / our_array.Length);
            return output;
        }

    }
}
