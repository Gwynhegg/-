using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_static_classes
{
    class StrangeSymbols
    {
        private int first_arg;
        private char second_arg;

        public StrangeSymbols(int a, char c)
        {
            first_arg = a;
            second_arg = c;
        }

        public StrangeSymbols(double d)
        {
            first_arg  = (int)(d * 100 % 100);
            second_arg = (char)Math.Floor(d);
        }

        public void getArgs()
        {
            Console.WriteLine("Аргументы: " + first_arg + " " + second_arg);
        }
    }
}
