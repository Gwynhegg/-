using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задание 1
            FirstTask();

            //Задание 2
            SecondTask();

            //Задание 3
            ThirdTask();

            //Задание 4
            ForthTask();

            //Задание 5
            FifthTask();

            //Задание 6
            SixthTask();

            //Задание 7
            SeventhTask();

            //Задание 8
            EighthTask();

            //Задание 9
            NinthTask();
            
            //Задание 10;
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
                    Console.WriteLine("Введите количество элементов массива (числа, при делении на 5 дающие в остатке 2).");
                    int N = Int32.Parse(Console.ReadLine());
                    int[] numbers_array = new int[N];
                    numbers_array[0] = 2;
                    for (int i = 0; i < N - 1; i++)
                    {
                        numbers_array[i + 1] = numbers_array[i] + 5;
                    }

                    Console.WriteLine("Полученный массив:");
                    for (int i = 0; i < N; i++)
                    {
                        Console.Write(numbers_array[i] + " ");
                    }
                    Console.WriteLine();
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("ЧИсло N не удовлетворяет поставленной задаче.");
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
                    Console.WriteLine("Данная программа выводит степени двойки от 0 до 10.");
                    int array_size = 11;
                    int[] degrees = new int[array_size];
                    degrees[0] = 1;
                    for (int i = 1; i < array_size; i++)
                    {
                        degrees[i] = degrees[i - 1] * 2;
                    }

                    Console.WriteLine("ТУДАААААА");
                    for (int i = 0; i < array_size; i++)
                    {
                        Console.Write(degrees[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("СЮДАААААА");
                    for (int i = array_size - 1; i >= 0; i--)
                    {
                        Console.Write(degrees[i] + " ");
                    }
                    Console.WriteLine();
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Возникла ошибка. ПОЧЕМУ ТАК?");
                }
            }
        }

        static void ThirdTask()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Эта программа выводит 10 символов, стоящих на нечетных позициях.");
                    int array_size = 10;
                    char[] symbols_array = new char[array_size];
                    symbols_array[0] = 'a';
                    for (int i = 1; i < array_size; i++)
                    {
                        symbols_array[i] = (char)(symbols_array[i - 1] + 2);
                    }
                    Console.WriteLine("Вперед:");
                    for (int i = 0; i < array_size; i++)
                    {
                        Console.Write(symbols_array[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Назад:");
                    for (int i = array_size - 1; i >= 0; i--)
                    {
                        Console.Write(symbols_array[i] + " ");
                    }
                    Console.WriteLine();
                    flag = false;
                   
                }
                catch
                {
                    Console.WriteLine("Что-то пошло не так.");
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
                    char[] consonant = new char[10];
                    consonant[0] = 'B';
                    int start_index = 0,step=1;
                    char temp;
                    while (start_index != 9)
                    {
                        temp = (char)(consonant[0]+step);
                        if (temp != 'A' && temp != 'E' && temp != 'I')  consonant[++start_index] = temp;
                        step++;
                    }
                    Console.WriteLine("Программа выведет 10 заглавных согласных.");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(consonant[i] + " ");
                    }
                    Console.WriteLine();
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Something went wrong...");
                }
            }
        }

        static void FifthTask()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Программа создает массив случайных чисел и определяет минимальное.Пожалуйста, введите N:");
                    int N = Int32.Parse(Console.ReadLine());
                    int[] random_array = new int[N];
                    Random rnd = new Random();
                    int minimal_element=0;
                    Console.WriteLine("Выводим массив:");
                    for (int i = 0; i < N; i++)
                    {
                        random_array[i] = rnd.Next(1, 100);
                        Console.Write(random_array[i] + " ");
                        if (i == 0) minimal_element = random_array[i]; else
                        {
                            if (random_array[i] < minimal_element) minimal_element = random_array[i];
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Минимальный элемент = " + minimal_element);
                    Console.Write("Индекс(Ы) = ");
                    for (int i = 0; i < N; i++)  if (random_array[i] == minimal_element) Console.Write((i) + " ");
                    Console.WriteLine();
                    Console.WriteLine("That's all, folks.");
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("ЧП при вводе значения.");
                }
            }          
        }

        static void SixthTask()
        {
            //Для добавления напряжения текущему заданию совместим его с проверкой алгоритмов сортировки на скорость работы
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Введите количество элементов в предполагаемом массиве.");
                    int N = Int32.Parse(Console.ReadLine());
                    int[] numbers_array = new int[N];
                    Random rnd = new Random();
                    for (int i = 0; i < N; i++) numbers_array[i] = rnd.Next(1, 1000000);
                    Stopwatch stopWatch = new Stopwatch();

                    //Проверяем сортировку пузырьком
                    stopWatch.Restart();
                    BubbleSort(numbers_array);
                    stopWatch.Stop();
                    Console.WriteLine("Затраченное время: " + stopWatch.Elapsed);


                    //Проверяем сортировку вставками
                    stopWatch.Restart();
                    InsertSort(numbers_array);
                    stopWatch.Stop();
                    Console.WriteLine("Затраченное время: " + stopWatch.Elapsed);

                    //Проверяем шейкерную сортировку
                    stopWatch.Restart();
                    ShakerSort(numbers_array);
                    stopWatch.Stop();
                    Console.WriteLine("Затраченное время: " + stopWatch.Elapsed);

                    //Проверяем сортировку Шелла
                    stopWatch.Restart();
                    ShellSort(numbers_array);
                    stopWatch.Stop();
                    Console.WriteLine("Затраченное время: " + stopWatch.Elapsed);

                    //Тут автору стало лень, и напоследок он решил проверить быструю сортировку Хоара
                    stopWatch.Restart();
                    QuickSort(numbers_array,0,numbers_array.Length-1);
                    Console.WriteLine("Сортировка Хоара:");
                    for (int i = 0; i < numbers_array.Length; i++)
                    {
                        Console.Write(numbers_array[i] + " ");
                    }
                    stopWatch.Stop();
                    Console.WriteLine("Затраченное время: " + stopWatch.Elapsed);
                    Console.WriteLine("Похоже, Quick Sort действительно Quick");
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Кажется, что-то не так");
                }
            }
        }

        static void SeventhTask()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Введите число элементов массива:");
                    int N = Int32.Parse(Console.ReadLine());
                    char[] random_symbols = new char[N];
                    Random rnd = new Random();
                    Console.WriteLine("Массив до перестановки:");
                    for (int i = 0; i < N; i++)
                    {
                        random_symbols[i] = (char)rnd.Next(65, 90);
                        Console.Write(random_symbols[i] + " ");
                    }
                    Console.WriteLine();
                    char temp;
                    for (int i = 0; i < N / 2; i++)
                    {
                        temp = random_symbols[i];
                        random_symbols[i] = random_symbols[N-i-1];
                        random_symbols[N - i - 1] = temp;
                    }
                    Console.WriteLine("Массив после перестановки:");
                    for (int i = 0; i < N; i++)
                    {
                        Console.Write(random_symbols[i] + " ");
                    }
                    Console.WriteLine();
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("I've never asked for this...");
                }
            }
        }


        static void EighthTask()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Введите размерность двумерного массива (N и M, через пробел).");
                    string[] input = Console.ReadLine().Split(' ');
                    int N = Int32.Parse(input[0]), M = Int32.Parse(input[1]);
                    int[,] first_matrix = new int[N, M];
                    int[,] reverse_matrix = new int[M, N];
                    Random rnd = new Random();
                    Console.WriteLine("Аккуратно выводим первую матрицу: ");
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            first_matrix[i, j] = rnd.Next(10);
                            Console.Write(first_matrix[i, j] + " ");
                            //Для того, чтобы сэкономить время и место, перестановка будет осуществлена прямо при заполнения первоначального массива
                            //(Все равно алгоритм не поменяется, а в программе, как и в мире, станет на два цикла меньше. Оптимизм!)
                            reverse_matrix[j, i] = first_matrix[i, j];
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Выводим обратную матрицу:");
                    for (int i = 0; i < M; i++)
                    {
                        for (int j = 0;j < N; j++)
                        {
                            Console.Write(reverse_matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Заблудился в двух измерениях...");
                }
            }
        }

        static void NinthTask()
        {
            bool flag = true;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите размерность двумерного массива (N и M, через пробел).");
                    string[] input = Console.ReadLine().Split(' ');
                    int N = Int32.Parse(input[0]), M = Int32.Parse(input[1]);
                    int[,] first_matrix = new int[N, M];
                    Random rnd = new Random();
                    Console.WriteLine("Аккуратно выводим первую матрицу: ");
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < M; j++)
                        {
                            first_matrix[i, j] = rnd.Next(10);
                            Console.Write(first_matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }

                    int random_row = rnd.Next(N);
                    int random_col = rnd.Next(M);
                    Console.WriteLine("Строка №" + (random_row+1) + " и столбец №" + (random_col+1) + ",вы приговорены к уничтожению!");
                    int[,] new_array = new int[N - 1, M - 1];
                    int index_i=0, index_j = 0;
                    int new_i=0, new_j=0;
                    while (index_i != N)
                    {
                        if (index_i != random_row)
                        {
                            index_j = 0;
                            new_j = 0;
                            while (index_j != M)
                            {
                                if (index_j != random_col)
                                {
                                    new_array[new_i, new_j] = first_matrix[index_i, index_j];
                                    new_j++;
                                }
                                index_j++;
                            }
                            new_i++;
                        }
                        index_i++;
                    }

                    Console.WriteLine("Массив после удаления строки и столбца:");
                    for (int i = 0; i < N - 1; i++)
                    {
                        for (int j = 0; j < M - 1; j++)
                        {
                            Console.Write(new_array[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Мушкет и жену не дам никому, хехе!");
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
                    Console.WriteLine("Введите размерность двумерного массива (N и M, через пробел).");
                    string[] input = Console.ReadLine().Split(' ');
                    int N = Int32.Parse(input[0]), M = Int32.Parse(input[1]);
                    char[,] field = new char[N, M];
                    int starting_point_X = 0, starting_point_Y = 0;
                    field[starting_point_Y, starting_point_X] = '>';
                    bool to_left = true, to_down = true, to_right = true, to_up = true;
                    bool there_is_no_steps = false;

                    while (!there_is_no_steps)
                    {
                        there_is_no_steps = true;
                        while (to_right)
                        {
                            if (starting_point_X < M-1)
                            {
                                if (field[starting_point_Y, starting_point_X + 1] != 'V')
                                {
                                    there_is_no_steps = false;
                                    field[starting_point_Y, ++starting_point_X] = '>';
                                    ShowMeYourSnake(field, N, M);
                                }
                                else to_right = false;
                            }
                            else to_right = false;
                        }
                        while (to_down)
                        {
                            if (starting_point_Y < N-1)
                            {
                                if (field[starting_point_Y+1, starting_point_X] != '<')
                                {
                                    there_is_no_steps = false;
                                    field[++starting_point_Y, starting_point_X] = 'V';
                                    ShowMeYourSnake(field, N, M);
                                }
                                else to_down = false;
                            }
                            else to_down = false;
                        }
                        while (to_left)
                        {
                            if (starting_point_X >0)
                            {
                                if (field[starting_point_Y, starting_point_X-1] != '^')
                                {
                                    there_is_no_steps = false;
                                    starting_point_X -= 1;
                                    field[starting_point_Y, starting_point_X] = '<';
                                    ShowMeYourSnake(field, N, M);
                                }
                                else to_left = false;
                            }
                            else to_left = false;
                        }
                        while (to_up)
                        {
                            if (starting_point_Y > 0)
                            {
                                if (field[starting_point_Y-1, starting_point_X] != '>')
                                {
                                    there_is_no_steps = false;
                                    starting_point_Y -= 1;
                                    field[starting_point_Y, starting_point_X] = '^';
                                    ShowMeYourSnake(field, N, M);
                                }
                                else to_up = false;
                            }
                            else to_up = false;
                        }

                        to_right = true; to_down = true; to_left = true; to_up = true;
                    }
                    Console.WriteLine("Ride the snake...To the lake...");
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Боги, покажите тому, кто сбился с пути, где ошибка...");
                }
            }
        }

        static void ShowMeYourSnake(char[,] a,int N, int M)
        {
            Console.Clear();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            System.Threading.Thread.Sleep(1);
        }
        static int Partition(int[] array, int start, int end)
        {
            int temp;
            int marker = start;
            for (int i = start; i < end; i++)
            {
                if (array[i] < array[end])
                {
                    temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }

        static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;

            }
            int pivot = Partition(array, start, end);
            QuickSort(array, start, pivot - 1);
            QuickSort(array, pivot + 1, end);
        }

        static void ShellSort(int[] a)
        {
            int[] temp = a;
            int distance = a.Length / 2;
            bool averson_condition = false;
            while (averson_condition)
            {
                if (distance == 1) averson_condition = true;
                for (int i = 0; i < a.Length - distance; i++)
                {
                    if (temp[i] < temp[i + distance]) Swap(temp, i, i + distance);
                    distance = distance * 3 / 5;
                    if (distance < 1) distance = 1;
                }
            }
            Console.WriteLine("Cортировка Шелла:");
            for (int i = 0; i < a.Length; i++) Console.Write(temp[i] + " ");
            Console.WriteLine();
        }
        static void ShakerSort(int[] a)
        {
            int[] temp = a;
            int left = 1, right = a.Length - 1, last = right;
            while (left<right)
            {
                for (int j = right; j >= left; j--)
                    if (temp[j - 1] < temp[j])
                    {
                        Swap(temp, j - 1, j);
                        last = j;
                    }
                left = last;
                for (int j = left; j <= right; j++)
                    if (temp[j - 1] < temp[j])
                    {
                        Swap(temp, j - 1, j);
                        last = j;
                    }
                right = last - 1;
            }
            Console.WriteLine("Шейкерная сортировка:");
            for (int i = 0; i < a.Length; i++) Console.Write(temp[i] + " ");
            Console.WriteLine();
        }

        static void InsertSort(int[] a)
        {
            int[] temp_array = a;

            for (int i = 1; i < a.Length; i++)
            {
                int temp = temp_array[i]; int j = i - 1;
                while (j >= 0 && temp > a[j])
                    temp_array[j + 1] = temp_array[j--]; // сдвинуть элемент
                temp_array[j + 1] = temp; // поставить элемент на свое место
            }
            Console.WriteLine("Сортировка вставками:");
            for (int i = 0; i < a.Length; i++) Console.Write(temp_array[i] + " ");
            Console.WriteLine();
        }

        static void BubbleSort(int[] a)
        {
            int[] temp = a;
            bool averson_condition = false;
            while (!averson_condition)
            {
                averson_condition = true;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (temp[i] < temp[i + 1]) {
                        Swap(temp, i, i + 1);
                        averson_condition = false;
                    }
                }
            }

            Console.WriteLine("Сортировка пузырем:");
            for (int i = 0; i < a.Length; i++) Console.Write(temp[i] + " ");
            Console.WriteLine();
        }

        static void Swap(int[] array, int first_index, int second_index)
        {
            int temp = array[first_index];
            array[first_index] = array[second_index];
            array[second_index] = temp;
        }
    }
}
