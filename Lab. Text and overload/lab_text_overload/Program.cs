using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_text_overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Строки. Задание 1");
            //Задание 1
            Console.WriteLine("Введите строку для последующего добавления пробелов");
            Console.WriteLine(textAddSpace(Console.ReadLine()));
            Console.ReadKey();

            Console.WriteLine("Строки. Задание 2");
            //Задание 2
            Console.WriteLine("Введите строку, которую необходимо перевернуть");
            Console.WriteLine(textReverse(Console.ReadLine()));
            Console.ReadKey();

            Console.WriteLine("Строки. Задание 3");
            //Задание 3
            Console.WriteLine("Введите две строки для сравнения");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            Console.WriteLine(textComparison(input1, input2));
            Console.ReadKey();

            Console.WriteLine("Строки. Задание 4");
            //Задание 4
            Console.WriteLine("Введите две строки для сравнения по словарю");
            input1 = Console.ReadLine();
            input2 = Console.ReadLine();
            Console.WriteLine(textComparison1(input1, input2));
            Console.ReadKey();

            Console.WriteLine("Строки. Задание 5");
            //Задание 5
            Console.WriteLine("Введите строку и символ, позицию которого вы хотите найти");
            input1 = Console.ReadLine();
            char symb = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(string.Join(" ", textPositions(input1, symb)));
            Console.ReadKey();

            Console.WriteLine("Строки. Задание 6");
            //Задание 6
            Console.WriteLine("Введите строку, которую будем разбивать на символы");
            input1 = Console.ReadLine();
            Console.WriteLine(string.Join(" ", textDict(input1)));
            Console.ReadKey();

            Console.WriteLine("Строки. Задание 7");
            //Задание 7
            Console.WriteLine("Введите строку, а после два числа, первое из которых обозначает индекс начала подстроки, а второе - его длину");
            input1 = Console.ReadLine();
            string[] input = Console.ReadLine().Split(' ');
            int start = Int32.Parse(input[0]), length = Int32.Parse(input[1]);
            Console.WriteLine(textSubString(input1, start, length));
            Console.ReadKey();

            Console.WriteLine("Строки. Задание 8");
            //Задание 8
            MyString new_string = new MyString("hello there");
            new_string.Insert("asdasd", 100);
            new_string.Insert("? GENERAL KENOBI!", 11);
            Console.WriteLine(new_string.ToString());
            Console.ReadKey();

            Console.WriteLine("Строки. Задание 9");
            //Задание 9
            TextDismemberment new_dismember = new TextDismemberment("dadayada", 'a');
            Console.WriteLine(String.Join(" ", new_dismember.Dismember()));
            Console.WriteLine(new_dismember.ToString());
            Console.ReadKey();

            Console.WriteLine("Строки. Задание 10");
            //Задание 10
            ArrayWork new_array = new ArrayWork(10);
            Console.WriteLine(new_array.ToString());

            //Глава 2.Перегрузка операторов
            Console.ReadKey();

            Console.WriteLine("Операторы. Задание 1");
            //Задание 1
            CharOverload new_char = new CharOverload('A');
            Console.WriteLine(new_char.getSymb());
            new_char++;
            Console.WriteLine(new_char.getSymb());
            new_char = new_char + 10;
            Console.WriteLine(new_char.getSymb());
            new_char = new_char - 5;
            new_char--;
            Console.WriteLine(new_char.getSymb());
            Console.ReadKey();

            Console.WriteLine("Операторы. Задание 2");
            //Задание 2
            ArrayOverload overloaded_array = new ArrayOverload(10);
            Console.WriteLine(~overloaded_array);
            overloaded_array--;
            Console.WriteLine(~overloaded_array);
            overloaded_array = overloaded_array + 10;
            ArrayOverload another_array = new ArrayOverload(5);
            another_array = overloaded_array + another_array;
            Console.WriteLine(~another_array);
            Console.ReadKey();

            Console.WriteLine("Операторы. Задание 3");
            //Задание 3
            ComparisonOverload first_compare = new ComparisonOverload(10, 20);
            ComparisonOverload second_compare = new ComparisonOverload(5, 10);
            Console.WriteLine(first_compare < second_compare);
            Console.ReadKey();

            Console.WriteLine("Операторы. Задание 4");
            //Задание 4
            CombinedOverload first_combiner = new CombinedOverload(10, "avv");
            CombinedOverload second_combiner = new CombinedOverload(5, "FOR THE SIGMAR");
            Console.WriteLine(first_combiner > second_combiner);
            Console.WriteLine(first_combiner >= second_combiner);
            Console.WriteLine(first_combiner != second_combiner);
            Console.WriteLine(first_combiner.GetHashCode());
            Console.ReadKey();

            Console.WriteLine("Операторы. Задание 5");
            //Задание 5
            TrueFalseOverload true_or_false = new TrueFalseOverload(65, 'A');
            while (true_or_false)
            {
                Console.WriteLine(true_or_false.getChar());
                true_or_false++;
            }
            Console.ReadKey();

            Console.WriteLine("Операторы. Задание 6");
            //Задание 6
            EasyMathOverload first_op = new EasyMathOverload(7);
            EasyMathOverload second_op = new EasyMathOverload(10);
            if (first_op) Console.WriteLine("YEA");
            if (first_op & second_op) Console.WriteLine("AND WHAT");
            if (first_op | second_op) Console.WriteLine("YEAH");
            Console.ReadKey();

            Console.WriteLine("Операторы. Задание 7");
            //Задание 7
            StringOverload overloaded_string = new StringOverload("ABCDEF");
            int int_trans = (int)overloaded_string;
            char char_trans = (char)overloaded_string;
            StringOverload new_overloaded_string = (StringOverload)20;
            Console.WriteLine(int_trans + " " + char_trans + " " + new_overloaded_string.getString());
            Console.ReadKey();

            Console.WriteLine("Операторы. Задание 8");
            //Задание 8
            ArrayTypeOverload new_type_array = new ArrayTypeOverload(10, true);
            Console.WriteLine((string)new_type_array);
            Console.WriteLine((int)new_type_array);
            Console.WriteLine((string)((ArrayTypeOverload)20));
            Console.ReadKey();

            Console.WriteLine("Операторы. Задание 9");
            //Задание 9
            HardMathStuff new_hard_math = new HardMathStuff(10);
            HardMathStuff another_math = new HardMathStuff(20);
            new_hard_math = new_hard_math + another_math;
            Console.WriteLine(new_hard_math.getValue());
            another_math *= new_hard_math;
            Console.WriteLine(another_math.getValue());
            another_math -= new_hard_math;
            Console.WriteLine(another_math.getValue());
            Console.ReadKey();

            Console.WriteLine("Операторы. Задание 10");
            //Задание 10
            OverloadedCharHard first_overchar = new OverloadedCharHard('a');
            OverloadedCharHard second_overchar = new OverloadedCharHard('c');
            Console.WriteLine(first_overchar + second_overchar);
            Console.WriteLine(first_overchar - second_overchar);
            Console.ReadKey();

        }

        static string textAddSpace(string input)
        {
            return String.Join(" ", input.ToCharArray());
        }

        static string textReverse(string input)
        {
            char[] ch = input.ToCharArray();
            Array.Reverse(ch);
            return new string(ch);
        }

        static string textComparison(string s1, string s2)
        {
            if (s1.Length != s2.Length) return "Строки не равны"; else
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (Math.Abs((int)s1[i]) - (int)s2[i] > 1) return "Строки не равны"; 
                }
                return "Строки равны";
            }
        }

        static string textComparison1(string s1, string s2)
        {
            List<char> dict1 = new List<char>();
            List<char> dict2 = new List<char>();
            for (int i = 0; i < s1.Length; i++) if (!dict1.Contains(s1[i])) dict1.Add(s1[i]);
            for (int i = 0; i < s2.Length; i++) if (!dict2.Contains(s2[i])) dict2.Add(s2[i]);
            dict1.Sort(); dict2.Sort();
            if (dict1.Count != dict2.Count) return "Словари не совпадают"; else
            {
                for (int i = 0; i < dict1.Count; i++) if (dict1[i] != dict2[i]) return "Ловари не совпадают";
                return "Словари совпадают";
            }
        }

        static int[] textPositions(string s1, char ch)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == ch) indexes.Add(i);
            }
            if (indexes.Count > 0) return indexes.ToArray(); else return new int[1] { -1 };
        }

        static char[] textDict(string s)
        {
            List<char> dict = new List<char>();
            for (int i = 0; i < s.Length; i++) if (!dict.Contains(s[i])) dict.Add(s[i]);
            dict.Sort();
            return dict.ToArray();
        }

        static string textSubString(string s, int start, int length)
        {
            if (start >= s.Length) return "Невозможно найти подстроку"; else
            {
                int i = 0;
                string answer = "";
                while (i<length && start < s.Length)
                {
                    answer += s[start++];
                    i++;
                }
                return answer;
            }
        }
    }
}
