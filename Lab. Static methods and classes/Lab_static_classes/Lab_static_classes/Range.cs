using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_static_classes
{
    class Range
    {
        public static char start = 'A', end = 'Z';

        public static void showRange()
        {
            Console.WriteLine("Интервал от " + start + " до " + end);
            char temp = start;
            for (int i = 0; i < (int)end - (int)start+1; i++)
            {
                Console.Write((char)(temp++));
            }
            Console.WriteLine();
        }
    }
}
