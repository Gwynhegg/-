using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Properties_and_indexators
{
    class task6
    {
        private int[] array;

        public task6(params int[] values)
        {
            array = values;
        }

        public int this[int index]
        {
            get
            {
                if (index - 1 >= 0 && index - 1 < array.Length) return array[index - 1];
                return -1;
            }
            set
            {
                if (index - 1 >= 0 && index - 1 < array.Length) array[index - 1] = value;
            }
        }
    }
}
