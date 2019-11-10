using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_static_classes
{
    class ArrayWork
    {

        public void getInfo(params int[] a)
        {
            int max = a[0], min = a[0], sum = 0 ;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
                sum += a[i];
            }
            Console.WriteLine("Максимальный элемент = " + max);
            Console.WriteLine("Минимальный элемент = " + min);
            Console.WriteLine("Среднее значение = " + (double)(sum / a.Length));
        }

    }
}
