using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_text_overload
{
    class OverloadedCharHard
    {

        private char field;

        public OverloadedCharHard(char s)
        {
            field = s;
        }

        public char getChar()
        {
            return field;
        }

        public static string operator +(OverloadedCharHard e, OverloadedCharHard s)
        {
            string answer = e.getChar().ToString() + s.getChar().ToString();
            return answer;
        }

        public static int operator -(OverloadedCharHard e, OverloadedCharHard s)
        {
            return (int)(e.getChar()) - (int)(s.getChar());
        }
    }
}
