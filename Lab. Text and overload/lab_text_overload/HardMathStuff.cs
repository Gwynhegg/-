using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_text_overload
{
    class HardMathStuff
    {

        private int value;
        public int getValue()
        {
            return value;
        }
        public HardMathStuff(int s)
        {
            value = s;
        }

        public static HardMathStuff operator +(HardMathStuff e, HardMathStuff s)
        {
            return new HardMathStuff(e.getValue() + s.getValue());
        }

        public static HardMathStuff operator -(HardMathStuff e, HardMathStuff s)
        {
            return new HardMathStuff(e.getValue() - s.getValue());
        }

        public static HardMathStuff operator *(HardMathStuff e, HardMathStuff s)
        {
            return new HardMathStuff(e.getValue() * s.getValue());
        }
    }
}
