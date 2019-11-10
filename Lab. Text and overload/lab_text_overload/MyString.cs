using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_text_overload
{
    class MyString
    {
        private string this_string;

        public MyString(string str)
        {
            this_string = str;
        }

        public void Insert(string sub, int index)
        {
            if (index > this_string.Length) Console.WriteLine("Невозможно выполнить операцию"); else
            {
                this_string = this_string.Insert(index, sub);
            }
        }

        public override string ToString()
        {
            return this_string;
        }

    }
}
