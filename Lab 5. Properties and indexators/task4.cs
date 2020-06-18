using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Properties_and_indexators
{
    class task4
    {
        private int value;
        private string octo_value;

        public task4(int value)
        {
            this.value = value;
            octo_value = Convert.ToString(value, 8);
        }

        public int changedValue
        {
            set
            {
                if (value>0)
                {
                    this.value = value;
                    octo_value = Convert.ToString(value, 8);
                }
            }
        }

        public string octoValue
        {
            get
            {
                return octo_value;
            }
        }
    }
}
