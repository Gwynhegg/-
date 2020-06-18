using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.Properties_and_indexators
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1.
            //Console.WriteLine("Задание 1");
            //task1 new_char = new task1();
            //new_char.Char = 'B';
            //new_char.Char = '1';
            //Console.WriteLine(new_char.Char);
            //Console.ReadKey();

            //Задание 2.
            //Console.WriteLine("Задание 2");
            //task2 new_array = new task2(new int[]{ 1,2,3});
            //Console.WriteLine(new_array.ArrayElement);
            //new_array.ArrayElement = 5;
            //Console.WriteLine(new_array.ArrayElement);
            //Console.WriteLine(new_array.ArrayElement);
            //new_array.ArrayElement = 0;
            //Console.WriteLine(new_array.ArrayElement);
            //Console.WriteLine(new_array.ArrayElement);
            //Console.ReadKey();

            //Задание 3.
            //Console.WriteLine("Задание 3");
            //task3 task3_array = new task3(new int[] { 1, 2, 3, 4, 5 });
            //Console.WriteLine(task3_array.SumOf);
            //Console.ReadKey();

            //Задание 4.
            //Console.WriteLine("Задание 4");
            //task4 octopus = new task4(10);
            //Console.WriteLine(octopus.octoValue);
            //octopus.changedValue = 5;
            //Console.WriteLine(octopus.octoValue);
            //Console.ReadKey();

            //Задание 5.
            //Console.WriteLine("Задание 5");
            //task5 odd_numbers = new task5();
            //Console.WriteLine(odd_numbers.Odd);
            //Console.WriteLine(odd_numbers.Odd);
            //odd_numbers.Odd = 10;
            //Console.WriteLine(odd_numbers.Odd);
            //Console.WriteLine(odd_numbers.Odd);
            //Console.WriteLine(odd_numbers.Odd);
            //Console.ReadKey();

            //Задание 6.
            //Console.WriteLine("Задание 6");
            //task6 array_again = new task6(new int[] { 1, 2, 3, 4 });
            //Console.WriteLine(array_again[1]);
            //Console.WriteLine(array_again[6]);
            //array_again[2] = 10;
            //Console.WriteLine(array_again[2]);
            //Console.ReadKey();

            //Задание 7.
            //Console.WriteLine("Задание 7");
            //task7 binary_string = new task7(10);
            //Console.WriteLine(binary_string[0]);
            //Console.WriteLine(binary_string[1]);
            //Console.WriteLine(binary_string[6]);
            //Console.ReadKey();

            //Задание 8.
            //Console.WriteLine("Задание 8");
            //task8 such_hatred = new task8(10);
            //such_hatred[0] = 2;
            //Console.WriteLine(such_hatred.getValue());
            //such_hatred[6] = 56;
            //Console.WriteLine(such_hatred.getValue());
            //Console.ReadKey();

            //задание 9.
            //Console.WriteLine("Задание 9");
            //task9 max_array = new task9(new int[][] {new int[]{ 1, 2, 3 },new int[]{ 3, 4, 5 } });
            //Console.WriteLine(max_array[0, 1]);
            //max_array[0, 1] = 10;
            //Console.WriteLine(max_array[0]);
            //max_array[0] = 2;
            //Console.WriteLine(max_array[0]);
            //Console.ReadKey();

            //Задание 10.
            Console.WriteLine("Задание 10");
            task10 string_n_chars = new task10(new string[] { "abc", "qwerty", "idiot" });
            Console.WriteLine(string_n_chars[2]);
            Console.WriteLine(string_n_chars[50]);
            Console.WriteLine(string_n_chars[4, 10]);
            Console.ReadKey();

        }
    }
}
