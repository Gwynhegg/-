using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для тестов:");
            int input_number = Int32.Parse(Console.ReadLine());

            //Task 1. Проверка деления на 3
            DivideByThree(input_number);

            //Task 2. Остаток от деления на 5 = 2, и остаток от деления на 7 = 1. Например, число 22
            SomeHardMathStuff(input_number);

            //Task 3. Число делится на 4 и оно не меньше 10
            HarderAndHarder(input_number);

            //Task 4. Попадание числа в диапазон от 5 до 10
            Diapason(input_number);

            //Task 5. Количество тысяч во введенном числе
            HowManyThousands(input_number);

            //Task 6. Вторая справа цифра в восьмеричном представлении числа
            OctalRepresentation(input_number);

            //Task 7. Третий бит справа в двоичном представлении с помощью побитового сдвига
            Binary(input_number);

            //Task 8. Установить третий бит равным единице
            ThirdBit(input_number);

            //Task 9. Установить 4 бит равным нулю
            ForthBit(input_number);

            //Task 10. Установить значение второго бита на противоположное
            Inverse(input_number);
            Console.ReadKey();
        }

        static void DivideByThree(int num)
        {
            if (num % 3 == 0) Console.WriteLine("Число делится на три без остатка."); else Console.WriteLine("Число не делится на три.");
        }

        static void SomeHardMathStuff(int num)
        {
            if (num % 5 == 2 && num % 7 == 1) Console.WriteLine("Это число удовлетворяет условиям второй задачи."); else Console.WriteLine("Число не удовлетворяет условиям второй задачи.");
        }

        static void HarderAndHarder(int num)
        {
            if (num % 4 == 0 && num >= 10) Console.WriteLine("Число удовлетворяет условиям третьей задачи."); else Console.WriteLine("Число не удовлетворяет условиям третьей задачи.");
        }

        static void Diapason(int num)
        {
            if (num >= 5 && num <= 10) Console.WriteLine("Число в диапазоне от 5 до 10."); else Console.WriteLine("Число не в диапазоне от 5 до 10.");
        }

        static void HowManyThousands(int num)
        {
            Console.WriteLine("Во введенном числе " + (num / 1000 % 10) + " тысяч.");
        }

        static void OctalRepresentation(int num)
        {
            int temp = num;
            string output = "";
            while (num >= 8)
            {
                output = (num % 8) + output;
                num /= 8;
            }
            output = num + output;
            Console.WriteLine("Число в восьмеричной системе счисления равно:");
            Console.WriteLine(output);
            //Вышеуказанный код приведен для удобства в проверке. Ниже представлена финальная версия решения задачи
            Console.WriteLine("Вторая цифра справа в восьмеричном представлении равна " + (temp / 8 % 8));

            }

        static void Binary(int num)
        {
            int temp = num;
            string bin = "";
            while (temp >= 2)
            {
                bin = temp % 2 + bin;
                temp /= 2;
            }
            Console.WriteLine("Число в двоичном представлении:");
            Console.WriteLine(temp + bin);
            //Вышеуказанный код приведен для удобства в проверке. Ниже представлена финальная версия решения задачи
            Console.WriteLine("Третий бит справа равен: "+((num>>2)%2));
        }

        static void ThirdBit(int num)
        {
            int temp = num;
            string bin = "";
            while (temp >= 2)
            {
                bin = temp % 2 + bin;
                temp /= 2;
            }

            //Основная часть, где происходит замена на единицу. Получаем нужный разряд с помощью сдвига влево и используем побитовое ИЛИ
            if (bin.Length > 2)
            {
                num |= 1 << (bin.Length - 2);
                temp = num;
                bin = "";
                while (temp >= 2)
                {
                    bin = temp % 2 + bin;
                    temp /= 2;
                }
                Console.WriteLine("Число после замены третьего бита на единицу: ");
                Console.WriteLine(temp + bin);
                Console.WriteLine("Что равно = " + num);
            }
            else Console.WriteLine("Не хватает разрядов для задачи 8.");

        }

        static void ForthBit(int num)
        {
            int temp = num;
            string bin = "";
            while (temp >= 2)
            {
                bin = temp % 2 + bin;
                temp /= 2;
            }
            //Основная часть. Создаем маску, где все позиции, кроме четвертой, заняты единицами, а четвертая нулем. Для этого создаем маску сдвигом единицы на нужное
            //положение и инверсируем, после чего применяем операцию И с числом
            if (bin.Length > 3)
            {
                num = num & ~(1 << (bin.Length - 3));
                temp = num;
                bin = "";
                while (temp >= 2)
                {
                    bin = temp % 2 + bin;
                    temp /= 2;
                }
                Console.WriteLine("Число после замены четвертого бита на ноль: ");
                Console.WriteLine(temp + bin);
                Console.WriteLine("Что равно = " + num);
            }
            else Console.WriteLine("Недостаточно разрядов для задачи 9");
            
        }

        static void Inverse(int num)
        {
            int temp = num;
            string bin = "";
            while (temp >= 2)
            {
                bin = temp % 2 + bin;
                temp /= 2;
            }
            //Основная часть. Используя побитовый сдвиг, перемещаем единицу на вторую позицию слева. Применим операцию ИСКЛЮЧАЮЩЕЕ ИЛИ, которые при взаимодействии
            //с единицей принимает значение 0, а при взаимодействии с нулем - 1. Так как все остальные позиции заняты нулями, в них число не претерпевает изменений
            num ^=(1 << (bin.Length-1));
            temp = num;
            bin = "";
            while (temp >= 2)
            {
                bin = temp % 2 + bin;
                temp /= 2;
            }
            Console.WriteLine("Число после замены второго бита на противоположный:");
            Console.WriteLine(temp + bin);
            Console.WriteLine("Что равно = " + num);
        }
    }
}
