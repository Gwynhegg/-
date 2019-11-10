using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_static_classes
{
    class Trigon
    {

        public void getCos(double x)
        {
            double answer = 0;
            for (int i = 0; i < 10; i++)
            {
                answer += (Math.Pow(-1, i) * Math.Pow(x, 2 * i)) / (getFactorial(2 * i));
            }
            Console.WriteLine("Косинус от " + x + " равен " + answer);
        }

        public void getGiperSin(double x)
        {
            double answer = 0;
            for (int i = 0; i < 10; i++)
            {
                answer += Math.Pow(x, 2 * i + 1) / getFactorial(2 * i + 1);
            }
            Console.WriteLine("Гиперболический синус от " + x + " равен " + answer);
        }

        public void getGiperCos(double x)
        {
            double answer = 0;
            for (int i = 0; i < 10; i++)
            {
                answer += Math.Pow(x, 2 * i) / getFactorial(2 * i);
            }
            Console.WriteLine("Гиперболический косинус от " + x + " равен " + answer);
        }

        private int getFactorial(int x)
        {
            int answer = 1;
            for (int i = 1; i <= x; i++)
            {
                answer *= i;
            }
            return answer;
        }
    }
}
