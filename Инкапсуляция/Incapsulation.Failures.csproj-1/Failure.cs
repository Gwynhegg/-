using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.Failures
{
    public class Failure
    {
        int failure_type;


        public Failure(int type)
        {
            failure_type = type;
        }
        public int getType()
        {
            return failure_type;
        }

        public void setType(int type)
        {
            failure_type = type;
        }

        public bool isSerious()
        {
            if (failure_type % 2 == 0) return true; else return false;
        }
    }
}
