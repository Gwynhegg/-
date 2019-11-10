using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_text_overload
{
    class TextDismemberment
    {

        private string victim;
        private char desintegrator;

        public TextDismemberment(string input, char inp_char)
        {
            this.victim = input;
            this.desintegrator = inp_char;
        }

        public string[] Dismember()
        {
            string[] output = victim.Split(desintegrator);
            return output;
        }

        public override string ToString()
        {
            string output = "Base string: " + victim + '\n';
            output += "Separator: " + desintegrator + '\n';
            output += "Separation: " + String.Join(" ", this.Dismember());
            return output;
        }
    }
}
