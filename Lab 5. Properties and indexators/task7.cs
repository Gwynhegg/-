using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Properties_and_indexators
{
    class task7
    {
        private int value;
        public task7(int value)
        {
            this.value = value;
        }

        public char this[int index]
        {
            get
            {
                string temp = Convert.ToString(value, 2);
                if (index >= 0 && index < temp.Length) return temp[temp.Length-index-1]; else return '#';
            }
        }
    }
}
