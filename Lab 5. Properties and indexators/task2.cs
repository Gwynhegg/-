using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Properties_and_indexators
{
    class task2
    {
        private int[] array;
        private int current_element = 0;

        public task2(params int[] values)
        {
            this.array = values;
        }

        public int ArrayElement
        {
            get
            {
                if (current_element == array.Length) current_element = 0;
                return array[current_element++];
            }
            set
            {
                if (current_element == array.Length) current_element = 0;
                array[current_element] = value;
            }
        }
    }
}
