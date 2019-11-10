using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_static_classes
{
    class CharText
    {
        private char symb;
        private string text;

        public void updateParam(char temp)
        {
            symb = temp;
        }

        public void updateParam(string text)
        {
            this.text = text;
        }

        public void updateParam(char[] chars)
        {
            if (chars.Length == 1) symb = chars[0]; else
            {
                text = "";
                foreach (char e in chars) text += e;
            }
        }
        public void getValues()
        {
            try
            {
                Console.WriteLine("Символьное значение = " + symb + " , текст = " + text);
            }
            catch
            {
                Console.WriteLine("Одной из переменной не присвоено значение!");
            }
        }
    }
}
