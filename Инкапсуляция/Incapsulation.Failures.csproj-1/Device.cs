using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.Failures
{
    public class Device
    {
        private int device_id;
        private string device_name;
        private object[] times;
        private Failure type_of_failure;

        public Device()
        {
        }

        public bool checkDeadline(Deadline date)
        {
            int vYear = (int)times[2];
            int vMonth = (int)times[1];
            int vDay = (int)times[0];
            if (vYear < date.getYear()) return true;
            if (vYear > date.getYear()) return false;
            if (vMonth < date.getMonth()) return true;
            if (vMonth > date.getMonth()) return false;
            if (vDay < date.getDay()) return true;
            return false;
        }
        public Device(int id, string name, object[] times, int failure_type)
        {
            device_id = id;
            device_name = name;
            this.times = times;
            type_of_failure = new Failure(failure_type);
        }

        public bool isFailureSerious()
        {
            try
            {
                return type_of_failure.isSerious();
            }
            catch
            {
                return false;
            }
        }
        public void setFailureType(int type)
        {
            type_of_failure = new Failure(type);
        }

        public int getFailureType()
        {
            return type_of_failure.getType();
        }
        public void setName(string name)
        {
            device_name = name;
        }

        public string getName()
        {
            return device_name;
        }

        public void setId(int id)
        {
            device_id = id;
        }

        public int getId()
        {
            return device_id;
        }

        public void setTimes(object[] times)
        {
            this.times = times;
        }

        public object[] getTimes()
        {
            return times;
        }
    }
}
