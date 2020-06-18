using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_static_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Задания по главе №5. Статические методы
            //Задание 1
            Console.WriteLine("Введите аргумент для вычисления двойного факториала:");
            int input_data = Int32.Parse(Console.ReadLine());
            int answer = staticRecFirstTask(input_data);
            Console.WriteLine("Ответ, полученный с помощью всемогущей рекурсии = " + answer);
            answer = staticSimpleFirstTask(input_data);
            Console.WriteLine("Ответ, полученный обычным способом = " + answer);
            Console.ReadKey();

            //Задание 2
            Console.WriteLine("Введите аргумент для вычисления суммы квадратов натуральных чисел:");
            input_data = Int32.Parse(Console.ReadLine());
            answer = staticRecSumOfNatural(input_data);
            Console.WriteLine("Сумма, полученная способов бесподобной рекурсии = " + answer);
            answer = staticSimpleSumOfNatural(input_data);
            Console.WriteLine("Сумма, полученная скучным методом = " + answer);
            Console.ReadKey();

            //Задание 3
            Console.WriteLine("Введите количество элементов, которые будет содержать расширенный массив:");
            input_data = Int32.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] new_array = new int[rnd.Next(1, 10)];
            Console.WriteLine("Массив до изменения:");
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = rnd.Next(10);
                Console.Write(new_array[i] + " ");
            }
            Console.WriteLine();
            ref int[] array_ref = ref staticRefArray(ref new_array, input_data);
            Console.WriteLine("Массив после изменения:");
            for (int i = 0; i < array_ref.Length; i++) Console.Write(array_ref[i] + " ");
            Console.WriteLine();
            Console.ReadKey();

            //Задание 4
            Console.WriteLine("Введите количество элементов в символьном массиве, который будет пребразован в числовой:");
            input_data = Int32.Parse(Console.ReadLine());
            char[] char_array = new char[input_data];
            Console.WriteLine("Созданный символьный массив:");
            for (int i = 0; i < input_data; i++)
            {
                char_array[i] = (char)rnd.Next(60,90);
                Console.Write(char_array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Целочисленный массив кодов символов:");
            int[] char_ref =  staticRefChars(ref char_array);
            Console.WriteLine(string.Join(" ", char_ref));
            Console.ReadKey();

            //Задание 5
            Console.WriteLine("Введите количество элементов в массиве, для которого будет вычислено среднее значение:");
            input_data = Int32.Parse(Console.ReadLine());
            int[] numbers_array = new int[input_data];
            Console.WriteLine("Созданный массив:");
            for (int i = 0; i < input_data; i++)
            {
                numbers_array[i] =rnd.Next(100);
                Console.Write(numbers_array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Среднее значение элементов массива = " + staticAverage(numbers_array));
            Console.ReadKey();
            */
                int input_data;
            Random rnd = new Random();
            //Задание 6
            Console.WriteLine("Введите размер двухмерного массива:");
            input_data = Int32.Parse(Console.ReadLine());
            int[,] numbers = new int[input_data, input_data];
            for (int i=0;i<input_data;i++)
                for (int j = 0; j < input_data; j++)
                {
                    numbers[i, j] = rnd.Next(100);
                }
            int i1, i2;
            Console.WriteLine("Максимальное значение массива: " + staticFindMax(numbers, out i1, out i2));
            Console.ReadKey();

            //Задание 7
            Console.WriteLine("Введите количество элементов в символьном массиве:");
            input_data = Int32.Parse(Console.ReadLine());
            char[] chars_array = new char[input_data];
            Console.WriteLine("Выводим сформированный массив:");
            for (int i = 0; i < input_data; i++)
            {
                chars_array[i] = (char)rnd.Next(60,90);
                Console.Write(chars_array[i] + " ");
            }
            Console.WriteLine();
            chars_array = staticSwapChars(chars_array);
            Console.WriteLine("После замены: ");
            Console.WriteLine(string.Join(" ", chars_array));
            Console.ReadKey();

            //Задание 8
            Console.WriteLine("Введите два числа или символа через пробел для создания массива:");
            string[] input = Console.ReadLine().Split(' ');
            try
            {
                int arg1 = Int32.Parse(input[0]);
                int arg2 = Int32.Parse(input[1]);
                Console.WriteLine("Сформированный массив:");
                Console.WriteLine(string.Join(" ", staticOverloadDiap(arg1, arg2)));
            }
            catch
            {
                if (input[0].Length == 1 && input[1].Length == 1)
                {
                    char arg1 = Convert.ToChar(input[0]);
                    char arg2 = Convert.ToChar(input[1]);
                    Console.WriteLine("Сформированный массив:");
                    Console.WriteLine(string.Join(" ", staticOverloadDiap(arg1, arg2)));

                }
            }
            Console.ReadKey();

            //Задание 9
            Console.WriteLine("Введите произвольное количество числовых переменных для нахождения максимума и минимума:");
            int[] min_max = staticFindMinMax(Console.ReadLine().Split(' '));
            Console.WriteLine("Найденный минимум: " + min_max[0] + " , найденный максимум: " + min_max[1]);
            Console.ReadKey();

            //Задание 10
            Console.WriteLine("Введите текст. После к нему будут добавленный символы:");
            string text = Console.ReadLine();
            Console.WriteLine("Введите произвольное количество символов (через пробел), для добавления в строку:");
            Console.WriteLine("Сформированная строка = " + staticAddText(text, Console.ReadLine().Split(' ')));
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("НАЧИНАЕМ РАБОТУ С КЛАССАМИ, СЛАВА ИМПЕРАТОРУ!");
            Console.ReadKey();

            //Задания по главе 6. Классы
            //Задание 1
            Console.WriteLine("Задание 1");
            Symb new_symbol = new Symb();
            new_symbol.setSymb('Z');
            Console.WriteLine(new_symbol.getCode());
            new_symbol.getInfo();
            Console.WriteLine("Изменяем значение на 'a'");
            new_symbol.setSymb('a');
            new_symbol.getInfo();
            Console.WriteLine();
            Console.ReadKey();

            //Задание 2
            Console.WriteLine("Задание 2");
            Range.showRange();
            Range.start = 'G';
            Range.showRange();
            Console.WriteLine();
            Console.ReadKey();

            //Задание 3
            Console.WriteLine("Задание 3");
            TwoFriends first_try = new TwoFriends();
            first_try.getArgs();
            TwoFriends second_try = new TwoFriends(5);
            second_try.getArgs();
            TwoFriends third_try = new TwoFriends(1, 3);
            third_try.getArgs();
            Console.ReadKey();

            //Задание 4
            Console.WriteLine("Задание 4");
            StrangeSymbols first = new StrangeSymbols(1, 'c');
            first.getArgs();
            StrangeSymbols second = new StrangeSymbols(90.65);
            second.getArgs();
            Console.ReadKey();

            //Задание 5
            Console.WriteLine("Задание 5");
            GetHundred not_send = new GetHundred();
            not_send.setValue();
            not_send.getValue();
            not_send.setValue(1050);
            not_send.getValue();
            Console.ReadKey();

            //Задание 6
            Console.WriteLine("Задание 6");
            MaxMin first_maxmin = new MaxMin();
            first_maxmin.getMaxMin();
            first_maxmin.updateMaxMin(5);
            first_maxmin.getMaxMin();
            first_maxmin.updateMaxMin(9, -5);
            first_maxmin.getMaxMin();
            Console.ReadKey();

            //Задание 7
            Console.WriteLine("Задание 7");
            CharText new_chartext = new CharText();
            new_chartext.updateParam('a');
            new_chartext.updateParam("dawdawdadawd");
            new_chartext.getValues();
            new_chartext.updateParam(new char[]{'g'});
            new_chartext.updateParam(new char[] { 'a', 'b', 'c' });
            new_chartext.getValues();
            Console.ReadKey();

            //задание 8
            Console.WriteLine("Задание 8");
            Value new_value = new Value();
            for (int i = 0; i < 10; i++) new_value.getValue();
            Console.ReadKey();

            //Задание 9
            Console.WriteLine("Задание 9");
            ArrayWork new_arrayWork = new ArrayWork();
            new_arrayWork.getInfo(1, 2, 3, 4, 5, 6, 7, 8, 9, 45);
            new_arrayWork.getInfo(new int[] { 1, 6, 7, 9, 10, 6 });
            Console.ReadKey();

            //задание 10
            Console.WriteLine("Задание 10");
            Trigon new_trig = new Trigon();
            new_trig.getCos(0.25);
            new_trig.getGiperSin(0.25);
            new_trig.getGiperCos(0.25);
            Console.ReadKey();
        }

        static int staticRecFirstTask(int arg)
        {
            if (arg == 2) return 2;
            else if (arg == 1) return 1;
            else return arg * staticRecFirstTask(arg - 2);
        }

        static int staticSimpleFirstTask(int arg)
        {
            int answer = 1;
            for (int i = arg; i > 0; i-=2) answer *= i;
            return answer;
        }

        static int staticRecSumOfNatural(int arg)
        {
            if (arg == 1) return 1;
            else return arg*arg + staticRecSumOfNatural(--arg);
        }

        static int staticSimpleSumOfNatural(int arg)
        {
            int answer = 0;
            for (int i = 1; i <= arg; i++) answer += i * i;
            return answer;
        }

        static ref int[] staticRefArray(ref int[] array, int number)
        {
            Array.Resize(ref array, number);
            return ref array;
        }

        static int[] staticRefChars(ref char[] array)
        {
            int[] fin_array = new int[array.Length];
            for (int i = 0; i < array.Length; i++) fin_array[i] = (int)array[i];
            return fin_array;

        }

        static double staticAverage(int[] array)
        {
            double average = 0;
            foreach (int e in array) average += e;
            return (double)average / array.Length;
        }
        
        static int staticFindMax(int[,] array, out int index, out int k)
        {
            int max = 0;
            index = 0;
            k = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        index = i;
                        k = j;
                    }
            return max;
        }

        static char[] staticSwapChars(char[] array)
        {
            char temp;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
            return array;
        }

        static int[] staticOverloadDiap(int start, int end)
        {
            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }
            int[] diap = new int[end - start+1];
            diap[0] = start;
            for (int i = 0; i < diap.Length-1; i++) diap[i + 1] = diap[i] + 1;
            return diap;
        }

        static char[] staticOverloadDiap(char start, char end)
        {
            if ((int)start > (int)end)
            {
                char temp = start;
                start = end;
                end = temp;
            }
            char[] diap = new char[(int)end - (int)start+1];
            diap[0] = start;
            for (int i=0;i<diap.Length-1;i++) diap[i+1]=(char)(diap[i]+1);
            return diap;
        }

        static int[] staticFindMinMax(string[] parameters)
        {
            int[] min_max = new int[2];
            min_max[0] = Int32.Parse(parameters[0]);
            min_max[1] = min_max[0];
            for (int i = 0; i < parameters.Length; i++)
            {
                if (Int32.Parse(parameters[i]) > min_max[1]) min_max[1] = Int32.Parse(parameters[i]);
                else if (Int32.Parse(parameters[i]) < min_max[0]) min_max[0] = Int32.Parse(parameters[i]);
            }
            return min_max;
        }

        static string staticAddText(string text, string[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++) text += parameters[i];
            return text;
        }
    }
}
