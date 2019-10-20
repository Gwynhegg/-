using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача №1.
            FirstTask();

            //Задача №2
            SecondTask();

            //Задача №3
            ThirdTask();

            //Задача №4
            ForthTask();

            //Задача №5
            FifthTask();

            //Задача №6
            SixthTask();

            //Задача №7
            SeventhTask();

            //Задача №8
            EighthTask();

            //Задача №9
            NinthTask();

            //Задача №10
            TenthTask();
            Console.ReadKey();
        }

        static void FirstTask()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Введите число для проверки делимости на 3 и 7:");
                    int input = Int32.Parse(Console.ReadLine());
                    if (input % 21 == 0) MessageBox.Show("Данное число делится на 3 и на 7", "Наши поздравления", MessageBoxButtons.OK);
                    else MessageBox.Show("Данное число не удовлетворяет условиям задачи", "БИБИП", MessageBoxButtons.OK);
                    flag = false;
                }
                catch
                {
                    MessageBox.Show("Возникла непредвиденная ошибка, устраните ошибку подальше от монитора", "ЭТО ШУТКА", MessageBoxButtons.OK);
                }
            }
        }

        static void SecondTask()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Введите два числа через пробел для последующего сравнения:");
                    string[] input_data = Console.ReadLine().Split(' ');
                    int first = Int32.Parse(input_data[0]), second = Int32.Parse(input_data[1]);
                    if (first > second) MessageBox.Show("Число " + first + " больше, чем " + second, "ОТВЕТ", MessageBoxButtons.OK);
                    else if (first == second) MessageBox.Show("Число " + first + " равно числу " + second, "ЭТО ОТВЕТ", MessageBoxButtons.OK);
                    else MessageBox.Show("Число " + first + " меньше, чем " + second, "ОТВЕТ", MessageBoxButtons.OK);
                    flag = false;
                }
                catch
                {
                    MessageBox.Show("Входные данные не удовлетворяют условиям", "Самфинг вронг", MessageBoxButtons.OK);
                }
            }
        }

        static void ThirdTask()
        {
            bool flag = true;
            int sum = 0;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Необходимо ввести число для сложнейших математических операций. Вводить последовательно:");
                    int temp = Int32.Parse(Console.ReadLine());
                    if (temp != 0) sum += temp;
                    else
                    {
                        if (sum != 42) MessageBox.Show("После всех математических преобразований Древний Компьютер выдал ответ: " + sum, "О мудрая машина", MessageBoxButtons.OK);
                        else MessageBox.Show("Кажется, мы познали суть мироздания", "42", MessageBoxButtons.OK);
                        flag = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Введенные данные не угодны Машине", "ЕРРОР", MessageBoxButtons.OK);
                }
            }
        }

        static void ForthTask()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Введите число в интервале от 1 до 7");
                    byte num_of_day = Byte.Parse(Console.ReadLine());
                    if (num_of_day > 7 || num_of_day < 1) throw new System.ArgumentException();
                    else
                    {
                        switch (num_of_day)
                        {
                            case 1: MessageBox.Show("Сегодня понедельник. Время умирать", "Понедельник", MessageBoxButtons.OK); break;
                            case 2: MessageBox.Show("Сегодня вторник. Отличный день", "Вторник", MessageBoxButtons.OK); break;
                            case 3: MessageBox.Show("Сегодня среда. Бесполезный день", "Среда", MessageBoxButtons.OK); break;
                            case 4: MessageBox.Show("Сегодня четверг. Ура, алгоритмы!", "Четверг", MessageBoxButtons.OK); break;
                            case 5: MessageBox.Show("Сегодня пятница. В преддверие свободы", "Пятница", MessageBoxButtons.OK); break;
                            case 6: MessageBox.Show("Сегодня суббота. Время спать", "Суббота", MessageBoxButtons.OK); break;
                            case 7: MessageBox.Show("Сегодня воскресенье. Время готовиться умирать", "Воскресенье", MessageBoxButtons.OK); break;
                        }
                        flag = false;
                    }
                }

                catch (ArgumentException e)
                {
                    MessageBox.Show("Данное число не находиться в необходимом диапазоне", "АШИПКА", MessageBoxButtons.OK);
                }
                catch (FormatException e)
                {
                    MessageBox.Show("Введенные данные некорректны", "ОШИБКА", MessageBoxButtons.OK);
                }
            }
        }

        static void FifthTask()
        {
            bool flag = true;
            try
            {
                while (flag)
                {
                    Console.WriteLine("Введите название дня недели для нахождения его порядкового номера:");
                    string day = Console.ReadLine().ToLower();
                    switch (day)
                    {
                        case "понедельник": MessageBox.Show("Сегодня первый день недели", "Понедельник", MessageBoxButtons.OK); break;
                        case "вторник": MessageBox.Show("Сегодня второй день недели", "Вторник", MessageBoxButtons.OK); break;
                        case "среда": MessageBox.Show("Сегодня третий день недели", "Среда", MessageBoxButtons.OK); break;
                        case "четверг": MessageBox.Show("Сегодня четвертый день недели", "Четверг", MessageBoxButtons.OK); break;
                        case "пятница": MessageBox.Show("Сегодня пятый день недели", "Пятница", MessageBoxButtons.OK); break;
                        case "суббота": MessageBox.Show("Сегодня шестой день недели", "Суббота", MessageBoxButtons.OK); break;
                        case "воскресенье": MessageBox.Show("Сегодня седьмой день недели", "Воскресенье", MessageBoxButtons.OK); break;
                        default: MessageBox.Show("Такого дня нет", "ERROR", MessageBoxButtons.OK); break;
                    }
                    flag = false;
                }
            }
            catch (FormatException e)
            {
                MessageBox.Show("Введенные данные некорректны", "ОШИБКА", MessageBoxButtons.OK);
            }
        }

        static void SixthTask()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Введите N Для подсчета суммы 2+4+...+2*N"); ;
                    int N = Int32.Parse(Console.ReadLine());
                    if (N < 1) throw new Exception();
                    int for_sum = 0, while_sum = 0, rec_sum = 0;
                    for (int i = 2; i <= 2 * N; i += 2)
                    {
                        for_sum += i;
                    }
                    int step = 2;
                    while (step <= N * 2)
                    {
                        while_sum += step;
                        step += 2;
                    }
                    rec_sum = Rec(2 * N, 0);
                    Console.WriteLine("Сумма, полученная с помощью цикла for: " + for_sum);
                    Console.WriteLine("Сумма, полученная с помощью цикла while: " + while_sum);
                    Console.WriteLine("Сумма, полученная с помощью всемогущей рекурсии: " + rec_sum);
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Возникла ошибка при вводе данных");
                }
            }
        }

        static int Rec(int n, int sum)
        {
            if (n == 2) return sum + 2;
            else
            {
                return Rec(n - 2, sum + n);
            }
        }

        static void SeventhTask()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Введите N для подсчета суммы квадратов чисел до N"); ;
                    int N = Int32.Parse(Console.ReadLine());
                    if (N < 1) throw new Exception();
                    long for_sum = 0, while_sum = 0, rec_sum = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        for_sum += i * i;
                    }
                    int step = 1;
                    while (step <= N)
                    {
                        while_sum += step * step;
                        step += 1;
                    }
                    rec_sum = RecQuad(N, 0);

                    long check_up = (N * (N + 1) * (2 * N + 1)) / 6;
                    Console.WriteLine("Сумма, полученная с помощью цикла for: " + for_sum);
                    Console.WriteLine("Сумма, полученная с помощью цикла while: " + while_sum);
                    Console.WriteLine("Сумма, полученная с помощью всемогущей рекурсии: " + rec_sum);
                    Console.WriteLine("Проверочная сумма: " + check_up);
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Возникла ошибка при вводе данных");
                }
            }
        }

        static long RecQuad(int n, long sum)
        {
            if (n == 1) return sum + 1;
            else return RecQuad(n - 1, sum += n * n);
        }

        static void EighthTask()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Введите N - количество желаемых чисел в последовательности Фибоначчи");
                    int N = Int32.Parse(Console.ReadLine());
                    if (N < 1) throw new Exception();
                    if (N == 1) Console.Write(1);
                    else if (N == 2) Console.Write("1 1");
                    else
                    {
                        Console.Write("Последовательность, полученная For-ом: 1 1");
                        int first = 1, second = 1, temp;
                        for (int i = 0; i < N - 2; i++)
                        {
                            temp = second;
                            second += first;
                            first = temp;
                            Console.Write(" " + second);
                        }
                        Console.WriteLine();
                        Console.Write("Последовательность, полученная While-ом: 1 1");
                        int step = N;
                        first = 1;
                        second = 1;
                        while (step > 2)
                        {
                            temp = second;
                            second += first;
                            first = temp;
                            step--;
                            Console.Write(" " + second);
                        }
                    }
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Упс, ошибка при вводе данных");
                }
            }
        }

        static void NinthTask()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Введите два числа через пробел. ПРограмма выведет последовательность чисел между ними");
                    string[] input = Console.ReadLine().Split(' ');
                    int first = Int32.Parse(input[0]), second = Int32.Parse(input[1]);
                    if (first > second)
                    {
                        int temp = first;
                        first = second;
                        second = temp;
                    }

                    Console.WriteLine("Решаем великим фором");
                    for (int i = first; i <= second; i++)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Решаем всемогущим вайлом");
                    while (first <= second)
                    {
                        Console.Write(first++ + " ");
                    }
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Возникла ошибка при обработке бытия");
                }
            }
        }

        static void TenthTask()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Введите число N.");
                    int N = Int32.Parse(Console.ReadLine());
                    int current_point = 1, sum = 0 ;
                    string answer = "";
                    while (N > 0)
                    {
                        if (current_point % 5 ==2 || current_point % 3 == 1)
                        {
                            sum += current_point;
                            N--;
                            answer += current_point + "+";
                        }
                        current_point++;
                    }
                    Console.WriteLine("Полученная сумма: " + answer.Remove(answer.Length-1) + "=" + sum);
                    flag = false;
                } catch
                {
                    Console.WriteLine("Обнаружена ошибка при вводе");
                }
            }
        }
    }
}
