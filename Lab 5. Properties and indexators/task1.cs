using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Properties_and_indexators
{
    class task1
    {
        private char character;

        public char Char
        {
            get
            {
                return character;
            }
            set
            {
                if (value >= 'A' && value <= 'Z') character = value;
            }
        }
    }
}
