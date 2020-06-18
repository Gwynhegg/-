using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Properties_and_indexators
{
    class task3
    {
        private int[] array;

        public task3(params int[] values)
        {
            array = values;
        }

        public int SumOf
        {
            get
            {
                return array.Sum();
            }
        }
    }
}
