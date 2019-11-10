using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_static_classes
{
    class MaxMin
    {
        private int max=0, min=0;

        public MaxMin()
        {

        }
        public MaxMin(int first)
        {
            if (first > max) max = first;
            if (first < min) min = first;
        }

        public MaxMin(int first, int second)
        {
            int temp = max;
            if (first > second && first > max) max = first;
            else if (second > first && second > max) max = second;
            if (first < min && first < second && first < temp) min = first;
            else if (second < min && second < first && second < temp) min = second;
            else if (temp < first && temp < second && temp < min) min = temp;
        }

        public void updateMaxMin(int first)
        {
            if (first > max) max = first;
            if (first < min) min = first;
        }
        public void updateMaxMin(int first,int second)
        {
            int temp = max;
            if (first > second && first > max) max = first;
            else if (second > first && second > max) max = second;
            if (first < min && first < second && first < temp) min = first;
            else if (second < min && second < first && second < temp) min = second;
            else if (temp < first && temp < second && temp < min) min = temp;
        }
        public void getMaxMin()
        {
            Console.WriteLine("Максимальное значение = " + max + " , минимальное = " + min);
        }
    }
}
