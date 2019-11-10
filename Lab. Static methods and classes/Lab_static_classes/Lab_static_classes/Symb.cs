using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_static_classes
{
    class Symb
    {
        private char symbol;


        public int getCode()
        {
            try
            {
                return (int)symbol;
            }
            catch
            {
                Console.WriteLine("Символу не присвоено значение!");
                return 0;
            }
        }

        public void setSymb(char symb)
        {
            this.symbol = symb;
        }

        public void getInfo()
        {
            try
            {
                Console.WriteLine("Значение символа = " + symbol + " , его код = " + (int)symbol);
            }
            catch
            {
                Console.WriteLine("Символу не присвоено значение!");
            }
        }
    }
}
