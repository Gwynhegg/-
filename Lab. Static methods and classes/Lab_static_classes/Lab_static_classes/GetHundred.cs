using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_static_classes
{
    class GetHundred
    {
        private int argument;

        public void setValue()
        {
            argument = 0;
        }

        public void setValue(int a)
        {
            if (a <= 100) argument = a; else argument = 100;
        }

        public void getValue()
        {
            try
            {
                Console.WriteLine("Аргумент равен ="+argument);
            }
            catch
            {
                Console.WriteLine("Аргументу не присвоено значение!");
            }
        }
    }
}
