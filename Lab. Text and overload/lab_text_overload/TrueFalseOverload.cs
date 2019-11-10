using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_text_overload
{
    class TrueFalseOverload
    {
        private int num_field;
        private char char_field;

        public TrueFalseOverload(int num, char ch)
        {
            num_field = num;
            char_field = ch;
        }

        public char getChar()
        {
            return char_field;
        }

        public int getNum()
        {
            return num_field;
        }

        public static bool operator true(TrueFalseOverload a)
        {
            if (Math.Abs(a.getNum() - (int)a.getChar()) <= 10) return true; else return false;
        }

        public static bool operator false(TrueFalseOverload a)
        {
            if (Math.Abs(a.getNum() - (int)a.getChar()) >= 10) return true; else return false;
        }

        public static TrueFalseOverload operator ++(TrueFalseOverload a)
        {
            return new TrueFalseOverload(a.getNum(),(char)((int)a.getChar()+1));
        }
    }
}
