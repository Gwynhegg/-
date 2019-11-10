using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_static_classes
{
    class TwoFriends
    {
        private int first_argument, second_argument;

        public TwoFriends()
        {
            first_argument = 0;
            second_argument = 0;
        }

        public TwoFriends(int a)
        {
            first_argument = a;
            second_argument = 0;
        }

        public TwoFriends(int a, int b)
        {
            first_argument = a;
            second_argument = b;
        }

        public void getArgs()
        {
            Console.WriteLine("Аргументы: " + first_argument + " " + second_argument);
        }
    }
}
