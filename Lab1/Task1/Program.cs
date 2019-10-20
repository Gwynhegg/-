using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Все задачи реализованы в виде методов в двух экземплярах (где это необходимо согласно ТЗ). Для запуска необходимой подпрограммы просто удалите комментарий
            //перед вызовом метода

            // Task 1. Способ 1.
            //  FirstForm();

            //Task 1. Способ 2.
            //  FirstConsole();

            //Task 2. Способ 1.
            //  SecondForm();

            //Task 2. Способ 2.
            // SecondConsole();

            // Task 3. Способ 1.
            // ThirdForm();

            // Task 3. Способ 2.
            // ThirdConsole();

            // Task 4. Способ 1.
            //ForthForm();

            //Task 4. Способ 2.
            //ForthConsole(); 

            //Task 5. Ура, без диалоговых окон!
            //FifthConsole();

            //Task 6. Способ 1. И снова проклятые окна...
            //SixthForm();

            //Task6. Способ 2.
            //SixthConsole();

            //Task 7. Способ 1.
            //SeventhForm();

            //Task 7. Способ 2.
            //SeventhConsole();

            //Task8. Способ 1.
            //EighthForm();

            //Task8. Способ 2.
            //EighthConsole();

            //Task 9. Способ 1. Становится жарко...
            //NinthForm();

            //Task 9. Способ 2.
            //NinthConsole();

            //Task 10. Способ 1.
            //TenthForm();

            //Task10. Способ 2.
            //TenthConsole();
            Console.ReadKey();
        }

        static void FirstForm()
        {
            string name="",surname="";
            bool is_not_valid = true;
            while (is_not_valid)
            {
                name = Interaction.InputBox("Как вас зовут?", "Представьтесь. уважаемый");
                surname = Interaction.InputBox("Ваша фамилия?", "Продолжайте, уважаемый");
                if (name == "" || surname == "") MessageBox.Show("Данные введены некорректно", "Нехорошо, уважаемый");
            }
                        MessageBox.Show("О, да вы же "+name+" "+surname);     
        }

        static void FirstConsole()
        {
            string name = "", surname = "";
            Console.WriteLine("Введите свое имя:");
            while (name == "")
            {
                name = Console.ReadLine();
            }
            Console.WriteLine("Введите фамилию:");
            while (surname == "")
            {
                surname = Console.ReadLine();
            }
            Console.WriteLine("ДА ВЫ ЖЕ " + name + " " + surname);
        }

        static void SecondForm()
        {
            string name = "", age="";
            int int_age = 0;
            bool is_not_valid = true;
            while (is_not_valid)
            {
                name = Interaction.InputBox("Как вас зовут?", "Представьтесь. уважаемый");
                age = Interaction.InputBox("Ваш возраст?", "Продолжайте, уважаемый");
                try
                {
                     int_age = Int32.Parse(age);
                } catch
                {
                    MessageBox.Show("ДАННЫЕ НЕКОРРЕКТНЫ", "АШИПКА", MessageBoxButtons.OK);
                }
                if (name == "" || int_age == 0) MessageBox.Show("Данные введены некорректно", "Нехорошо, уважаемый"); else is_not_valid = false;
            }
            MessageBox.Show("О, да вы же " + name + " и ваш возраст = " + int_age + " годиков!");
        }

        static void SecondConsole()
        {
            string name = "", age = "";
            int int_age = 0;
            Console.WriteLine("Введите свое имя:");
            while (name == "")
            {
                name = Console.ReadLine();
            }
            bool is_not_valid = true;
            while (is_not_valid)
            {
                Console.WriteLine("Введите возраст:");
                age = Console.ReadLine();
                try
                {
                    int_age = Int32.Parse(age);
                }
                catch
                {
                    Console.WriteLine("ДАННЫЕ НЕКОРРЕКТНЫ");
                }
                if (int_age != 0) is_not_valid = false;
            }
            Console.WriteLine("ДА ВЫ ЖЕ " + name + " И ВАМ " + int_age + " годиков!");
        }

        static void ThirdForm()
        {
            string day = "", month = "", date = "";
            int int_date = 0;
            bool is_not_valid = true;
            while (is_not_valid)
            {
                day = Interaction.InputBox("Введите текущий день", "Разогреваемся...");
                month = Interaction.InputBox("Введите текущий месяц", "Keep Going...");
                date = Interaction.InputBox("Введите текущий день в календаре", "Я КАЛЕНДАРЬ ПЕРЕВЕРНУ...");
                try
                {
                    int_date = Int32.Parse(date);
                }
                catch
                {
                    MessageBox.Show("Это не число!");
                }
                if (day == "" || month == "" || int_date == 0) MessageBox.Show("Данные некорректны"); else is_not_valid = false;
            }
            MessageBox.Show("По вашим словам, сегодня " + day + ", месяц " + month + ", на календаре " + int_date + " число");
        }

        static void ThirdConsole()
        {
            string day = "", month = "", date="";
            int int_date = 0;
            Console.WriteLine("Введите день недели:");
            while (day == "")
            {
                day = Console.ReadLine();
            }
            Console.WriteLine("Введите месяц:");
            while (month == "")
            {
                month = Console.ReadLine();
            }
            bool is_not_valid = true;
            while (is_not_valid)
            {
                Console.WriteLine("Введите номер дня в календаре(не третье сентября):");
                date = Console.ReadLine();
                try
                {
                    int_date = Int32.Parse(date);
                }
                catch
                {
                    Console.WriteLine("ДАННЫЕ НЕКОРРЕКТНЫ");
                }
                if (int_date != 0) is_not_valid = false;
            }
            Console.WriteLine("По вашим словам, сегодня " + day + ", месяц " + month + ", на календаре " + int_date + " число");
        }

        static void ForthForm()
        {
            string days = "", month = "";
            int int_days = 0;
            bool is_not_valid = true;
            while (is_not_valid)
            {
                month = Interaction.InputBox("Введите текущий месяц", "Вводите, пожалуйста...");
                days = Interaction.InputBox("Сколько дней в этом месяце?", "...");
                try
                {
                    int_days = Int32.Parse(days);
                }
                catch
                {
                    MessageBox.Show("Это не число!");
                }
                if (month == "" || int_days == 0) MessageBox.Show("Данные некорректны"); else is_not_valid = false;
            }
            MessageBox.Show("В месяце с ужасным названием " + month+ " ровно "+int_days+ " дней");
        }

        static void ForthConsole()
        {
            string month = "", days = "";
            int int_days = 0;
            Console.WriteLine("Название месяца:");
            while (month == "")
            {
                month = Console.ReadLine();
            }
            bool is_not_valid = true;
            while (is_not_valid)
            {
                Console.WriteLine("Введите количество дней в данном месяце:");
                days = Console.ReadLine();
                try
                {
                    int_days = Int32.Parse(days);
                }
                catch
                {
                    Console.WriteLine("ДАННЫЕ НЕКОРРЕКТНЫ");
                }
                if (int_days != 0) is_not_valid = false;
            }
            Console.WriteLine("В месяце с ужасным названием " + month + " ровно " + int_days + " дней");
        }

        static void FifthConsole()
        {
            Console.WriteLine("Введите год вашего рождения:");
            bool flag = true;
            while (flag)
            {
                try
                {
                    int year = Int32.Parse(Console.ReadLine());
                    if (DateTime.Now.Year - year >= 0)
                    {
                        Console.WriteLine("Все ясно, автору " + (DateTime.Now.Year - year) + " лет.");
                        flag = false;
                    }
                    else Console.WriteLine("Поздравляю, вас еще нет");
                }
                catch
                {
                    Console.WriteLine("ДАННЫЕ НЕКОРРЕКТНЫ");
                }
            }
        }

        static void SixthForm()
        {
            string name = "", year = "";
            int int_year=0;
            bool is_not_valid = true;
            while (is_not_valid)
            {
                name = Interaction.InputBox("Как вас зовут, милсдарь?", "Вводите, пожалуйста...");
                year = Interaction.InputBox("В каком году вы родились?", "...");
                try
                {
                    int_year = Int32.Parse(year);
                    if (name == "" || DateTime.Now.Year - int_year < 0) MessageBox.Show("Данные некорректны"); else is_not_valid = false;
                }
                catch
                {
                    MessageBox.Show("Айайай, нехорошо...");
                }           
            }
            MessageBox.Show("Милсдарь " + name + " , вам уже " + (DateTime.Now.Year - int_year) + " годиков!");
        }

        static void SixthConsole()
        {
            string name = "", year = "";
            int int_year = 0;
            bool is_not_valid = true;
            while (is_not_valid)
            {
                Console.WriteLine("Милсдарь, введите ваше имя:");
                name = Console.ReadLine();
                Console.WriteLine("Отлично, в каком году вы родились?");
                year = Console.ReadLine();
                try
                {
                    int_year = Int32.Parse(year);
                    if (name == "" || DateTime.Now.Year - int_year < 0) Console.WriteLine("Данные некорректны"); else is_not_valid = false;
                }
                catch
                {
                    Console.WriteLine("Айайай, нехорошо...");
                }
            }
            Console.WriteLine("Милсдарь " + name + " , вам уже " + (DateTime.Now.Year - int_year) + " годиков!");
        }

        static void SeventhForm()
        {
            string age = "";
            int int_age = 0,year_of_born=0;
            bool is_not_valid = true;
            while (is_not_valid)
            {
                try
                {
                    age = Interaction.InputBox("О прекрасный незнакомец, сколько вам лет?", "Ммм?");
                    int_age = Int32.Parse(age);
                    if (int_age >= 0)
                    {
                        year_of_born = DateTime.Now.Year - int_age;
                        is_not_valid = false;
                    }
                    else MessageBox.Show("Данные некорректны");
                }
                catch
                {
                    MessageBox.Show("Данные некорректны");
                }
            }
            MessageBox.Show("Вы родились в далеком " + year_of_born + " году");
        }

        static void SeventhConsole()
        {
            string age = "";
            int int_age = 0, year_of_born = 0;
            bool is_not_valid = true;
            while (is_not_valid)
            {
                try
                {
                    Console.WriteLine("О прекрасный незнакомец, сколько вам лет?");
                    age = Console.ReadLine();
                    int_age = Int32.Parse(age);
                    if (int_age >= 0)
                    {
                        year_of_born = DateTime.Now.Year - int_age;
                        is_not_valid = false;
                    }
                    else Console.WriteLine("Данные некорректны");
                }
                catch
                {
                    Console.WriteLine("Данные некорректны");
                }
            }
            Console.WriteLine("Вы родились в далеком " + year_of_born + " году");
        }

        static void EighthForm()
        {
            int first_num=0, second_num=0;
            bool is_not_valid = true;
            while (is_not_valid)
            {
                try
                {
                    first_num = Int32.Parse(Interaction.InputBox("Введите первое число", "..."));
                    second_num = Int32.Parse(Interaction.InputBox("Введите второе число", "..."));
                    is_not_valid = false;
                }
                catch
                {
                    MessageBox.Show("Введены не числа");
                    is_not_valid = true;
                }
            }
            MessageBox.Show("Полученная сумма: " + (first_num + second_num));
        }

        static void EighthConsole()
        {
            int first_num = 0, second_num = 0;
            bool is_not_valid = true;
            while (is_not_valid)
            {
                try
                {
                    Console.WriteLine("Введите первое число:");
                    first_num = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    second_num = Int32.Parse(Console.ReadLine());
                    is_not_valid = false;
                }
                catch
                {
                    Console.WriteLine("Введены не числа");
                    is_not_valid = true;
                }
            }
            Console.WriteLine("Полученная сумма: " + (first_num + second_num));
        }

        static void NinthForm()
        {
            int first_num = 0;
            bool is_not_valid = true;
            while (is_not_valid)
            {
                try
                {
                    first_num = Int32.Parse(Interaction.InputBox("Введите число", "..."));
                    is_not_valid = false;
                }
                catch
                {
                    MessageBox.Show("Это все шутки для вас?!");
                    is_not_valid = true;
                }
            }
            MessageBox.Show("Полученная последовательность: " + (first_num - 1) + " " + first_num + " " + (first_num + 1));
        }

        static void NinthConsole()
        {
            int first_num = 0;
            bool is_not_valid = true;
            while (is_not_valid)
            {
                try
                {
                    Console.WriteLine("Введите число:");
                    first_num = Int32.Parse(Console.ReadLine());
                    is_not_valid = false;
                }
                catch
                {
                    Console.WriteLine("Это все шутки для вас?!");
                    is_not_valid = true;
                }
            }
            Console.WriteLine("Полученная последовательность: " + (first_num - 1) + " " + first_num + " " + (first_num + 1));
        }

        static void TenthForm()
        {
            int first_num = 0, second_num = 0; ;
            bool is_not_valid = true;
            while (is_not_valid)
            {
                try
                {
                    first_num = Int32.Parse(Interaction.InputBox("Введите число", "..."));
                    second_num = Int32.Parse(Interaction.InputBox("Введите еще одно число", "..."));
                    is_not_valid = false;
                }
                catch
                {
                    MessageBox.Show("Мы тут серьезными вещами занимаемся!");
                    is_not_valid = true;
                }
            }
            MessageBox.Show("Сумма чисел равна = "+(first_num+second_num)+" , разность = "+(first_num-second_num));
        }

        static void TenthConsole()
        {
            int first_num = 0, second_num = 0; ;
            bool is_not_valid = true;
            while (is_not_valid)
            {
                try
                {
                    Console.WriteLine("Введите число:");
                    first_num = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Введите еще одно число:");
                    second_num = Int32.Parse(Console.ReadLine());
                    is_not_valid = false;
                }
                catch
                {
                    Console.WriteLine("Мы тут серьезными вещами занимаемся!");
                    is_not_valid = true;
                }
            }
            Console.WriteLine("Сумма чисел равна = " + (first_num + second_num) + " , разность = " + (first_num - second_num));
        }
    }
}
