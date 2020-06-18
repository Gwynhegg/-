using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Properties_and_indexators
{
    class task8
    {
        private int value;

        public task8(int value)
        {
            this.value = value;
        }

        public int getValue()
        {
            return value;
        }
        public int this[int index]
        {
            set
            {
                string temp = this.value.ToString();
                if (index >= temp.Length)
                {
                    int k = temp.Length;
                    for (int i = 0; i <= index - k; i++) temp = '0' + temp;
                }
                char[] temp_char = temp.ToCharArray();
                temp_char[temp.Length-index-1] = (value % 10).ToString()[0];
                temp = "";
                foreach (char e in temp_char) temp += e;
                this.value = Int32.Parse(temp);
            }
        }
    }
}
