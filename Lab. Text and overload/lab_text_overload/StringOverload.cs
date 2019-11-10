using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_text_overload
{
    class StringOverload
    {

        private string our_text;

        public StringOverload(string s)
        {
            this.our_text = s;
        }

        public string getString()
        {
            return our_text;
        }

        public static explicit operator int(StringOverload s)
        {
            return s.getString().Length;
        }

        public static explicit operator char(StringOverload s)
        {
            return s.getString()[0];
        }

        public static explicit operator StringOverload(int s)
        {
            string output = new String('A', s);
            return new StringOverload(output);
        }
    }
}
