using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.RationalNumbers
{
    public class Rational
    {
        private bool isNan = false;

        public bool IsNan
        {
            get
            {
                return isNan;
            }
            set
            {
                isNan = value;
            }
        }
        private int numerator;

        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }
        private int denominator;

        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                denominator = value;
            }
        }

        //Конструктор, принимающий делимое и делитель и проверяющий делитель на 0.
        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                isNan = true;
            }else
            {
                int NOD = euclid(numerator, denominator);
                if (Math.Abs(numerator) > Math.Abs(numerator / NOD))
                {
                    this.numerator = numerator / NOD;
                    this.denominator = denominator / NOD;
                    if ((numerator<0 && denominator < 0) || (numerator>0 && denominator<0))
                    {
                        this.numerator = -this.numerator;
                        this.denominator = -this.denominator;
                    }
                } else
                {
                    this.numerator = numerator;
                    this.denominator = denominator;
                    if ((numerator < 0 && denominator < 0) || (numerator > 0 && denominator < 0))
                    {
                        this.numerator = -this.numerator;
                        this.denominator = -this.denominator;
                    }
                }

            }    
        }

        public Rational(int numerator)
        {
            this.numerator = numerator;
            denominator = 1;
        }

        //Переопределение оператора конвертации в int
        public static implicit operator int(Rational r)
        {
            if (r.numerator%r.denominator!=0)throw new System.Exception(); else return (int)(r.numerator / r.denominator);
        }

        public static implicit operator double(Rational r)
        {
            if (r.denominator == 0) return double.NaN;
            return (double)r.numerator / (double)r.denominator;
        }

        //Создание оператора конвертации из Int в Rational
        public static implicit operator Rational(int i)
        {
            return new Rational(i, 1);
        }


        public static Rational operator /(Rational r1, Rational r2)
        {
            Rational temp = new Rational(r1.numerator * r2.denominator, r1.denominator * r2.numerator);
            if (r2.numerator == 0) temp.IsNan = true;
            return temp;
        }

        public static Rational operator *(Rational r1, Rational r2)
        {
            return new Rational(r1.numerator * r2.numerator, r1.denominator * r2.denominator);
        }

        public static Rational operator +(Rational r1, Rational r2)
        {
            return new Rational(r1.numerator * r2.denominator + r2.numerator * r1.denominator, r1.denominator * r2.denominator);
        }

        public static Rational operator -(Rational r1, Rational r2)
        {
            return new Rational(r1.numerator * r2.denominator - r2.numerator * r1.denominator, r1.denominator * r2.denominator);
        }

        private static int euclid(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != 0 && b != 0)
                if (a > b) a = a % b; else b = b % a;
            return a + b;
        }
    }   
}
