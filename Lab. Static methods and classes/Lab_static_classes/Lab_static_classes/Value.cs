using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_static_classes
{
    class Value
    {
        private int value = 0;

        public void getValue()
        {
            Console.WriteLine("Текущее значение = " + value++);
        }
    }
}
