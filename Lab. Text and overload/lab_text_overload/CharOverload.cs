using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_text_overload
{
    class CharOverload
    {

        private char symb;

        public CharOverload(char val)
        {
            symb = val;
        }

        public char getSymb()
        {
            return symb;
        }

        public static CharOverload operator ++(CharOverload c) {
            return new CharOverload((char)((int)c.getSymb() + 1));
        }

        public static CharOverload operator --(CharOverload c)
        {
            return new CharOverload((char)((int)c.getSymb() - 1));
        }

        public static CharOverload operator +(CharOverload c, int diap)
        {
            return new CharOverload((char)((int)c.getSymb() + diap));
        }

        public static CharOverload operator +(int diap, CharOverload c)
        {
            return new CharOverload((char)((int)c.getSymb() + diap));
        }

        public static CharOverload operator -(int diap, CharOverload c)
        {
            return new CharOverload((char)((int)c.getSymb() - diap));
        }

        public static CharOverload operator -(CharOverload c, int diap)
        {
            return new CharOverload((char)((int)c.getSymb() - diap));
        }
    }
}
