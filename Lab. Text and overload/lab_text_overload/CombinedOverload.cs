using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_text_overload
{
    class CombinedOverload
    {
        private int num_field;
        private string text_field;

        public CombinedOverload(int num, string text)
        {
            num_field = num;
            text_field = text;
        }

        public string getText()
        {
            return text_field;
        }

        public int getNum()
        {
            return num_field;
        }

        public static bool operator >(CombinedOverload a,CombinedOverload b)
        {
            if (a.getText().Length > b.getText().Length) return true; else return false;
        }

        public static bool operator <(CombinedOverload a, CombinedOverload b)
        {
            if (a.getText().Length < b.getText().Length) return true; else return false;
        }

        public static bool operator >=(CombinedOverload a, CombinedOverload b)
        {
            if (a.getNum() > b.getNum()) return true; else return false;
        }

        public static bool operator <=(CombinedOverload a, CombinedOverload b)
        {
            if (a.getNum() > b.getNum()) return true; else return false;
        }

        public static bool operator ==(CombinedOverload a, CombinedOverload b)
        {
            if (a.getNum() == b.getNum() && a.getText()==b.getText()) return true; else return false;
        }

        public static bool operator !=(CombinedOverload a, CombinedOverload b)
        {
            if (a.getNum() != b.getNum() || a.getText() != b.getText()) return true; else return false;
        }

        public bool Equals(CombinedOverload a)
        {
            if (a.getNum() == this.getNum() && a.getText() == this.getText()) return true; else return false;
        }

        public int GetHashCode()
        {
            return this.getText().GetHashCode();
        }
    }
}
