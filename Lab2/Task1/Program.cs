using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            /*      Console.WriteLine("Введите число для первой задачи:");
                  input = Console.ReadLine();
                  FirstTask(input);

                  Console.WriteLine("Введите числа для проверки второй задачи, через пробел");
                  input = Console.ReadLine();
                  SecondTask(input);

                  input = "";
                  int sum = 0;
                  while (input!="0")
                  {
                      Console.WriteLine("Введите числа, которое вы хотите прибавить. Если вы хотите закончить работу с системой, введите ноль:");
                      input = Console.ReadLine();
                      sum = ThirdTask(sum,input);
                  }
                  MessageBox.Show("Полученная сумма равна " + sum, "Результат", MessageBoxButtons.OK);
                  */
            Console.WriteLine("Введите число для выполнения четвертой задачи");
            input = Console.ReadLine();
            ForthTask(input);
        }

        static void FirstTask(string input)
        {
            try
            {
                int temp = Int32.Parse(input);
                if (temp % 3 == 0 && temp % 7 == 0) MessageBox.Show("Число делится и на 3, и на 7. Виват!", "Это успех", MessageBoxButtons.OK);
                else MessageBox.Show("Увы, проверка показала неутешительные результаты", "Фиаско", MessageBoxButtons.OK);
            } catch
            {
                MessageBox.Show("При вводе данных возникла ошибка. Повторите ввод", "ERROR", MessageBoxButtons.OK);
            }
        }

        static void SecondTask(string input)
        {
            try
            {
                string[] input_stream = input.Split(' ');
                int first = Int32.Parse(input_stream[0]), second = Int32.Parse(input_stream[1]);
                if (first > second) MessageBox.Show("Первое число больше второго!", "Результат", MessageBoxButtons.OK);
                else if (first == second) MessageBox.Show("Числа равны, и это удивительно", "Результат", MessageBoxButtons.OK);
                else MessageBox.Show("Первое число меньше, чем второе", "Результат", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Формат входных данных неверен, повторите еще раз", "АШИПКА", MessageBoxButtons.OK);
            }
        }

        static int ThirdTask(int sum, string input)
        {
            try
            {
                int temp = Int32.Parse(input);
                sum += temp;
                return sum;
            } catch
            {
                MessageBox.Show("Возникла непредвиденная ошибка при вводе", "ОШИБКА", MessageBoxButtons.OK);
                return 0;
            }
        }

        static void ForthTask(string input)
        {
            try
            {
                int temp = Int32.Parse(input);
                if (temp > 0 && temp < 8)
                {

                } else throw new Exception("ALARM");
            } catch (Exception e)
            {
                if (e == SystemException) MessageBox.Show("Данное число не входит в указанный диапазон", "ALARM", MessageBoxButtons.OK);
            }
        }
    }
}
