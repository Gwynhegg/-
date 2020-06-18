using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Properties_and_indexators
{
    class task10
    {
        private string[] array;

        public task10(string[] array)
        {
            this.array = array;
        }

        public string this[int index]
        {
            get
            {
                index %= array.Length;
                return array[index];
            }
            set
            {
                index %= array.Length;
                array[index]=value;
            }
        }

        public char this[int index, int char_index]
        {
            get
            {
                index %= array.Length;
                char_index %= array[index].Length;
                return array[index][char_index];
            }
        }
    }
}
