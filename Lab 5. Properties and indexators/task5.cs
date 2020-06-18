using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Properties_and_indexators
{
    class task5
    {
        private int start = 1;

        public int Odd
        {
            get
            {
                return (start++) * 2 - 1;
            }
            set
            {
                start = value;
            }
        }
    }
}
