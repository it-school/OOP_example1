using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example1
{
    class Fraction
    {
        private int numerator;  // числитель
        private int denominator; // знаменатель

        public int Numerator { get => numerator; set => numerator = value; }
        public int Denominator { get => denominator; set => denominator = (value != 0 ? value : 1); }

        public Fraction()
        {
            this.numerator = 0;
            this.denominator = 1;
        }

        public Fraction(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.Denominator = denominator;
        }


        override public String ToString()
        {
            return " " + this.Numerator + "/" + this.Denominator;
        }

        public void Reverse()
        {
            int numerator = this.Numerator;
            this.Numerator = this.Denominator;
            this.Denominator = numerator;
        }

        public String ReversedString()
        {
            Fraction tempFraction = new Fraction(this.numerator, this.denominator);
            tempFraction.Reverse();
            return tempFraction.ToString();
        }

        public Fraction Reversed()
        {
            return new Fraction(this.denominator, this.numerator);
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction temp = new Fraction(f1.numerator, f1.denominator);
            temp.Add(f2);
            temp.Simplify();
            return temp;
        }

        public void Add(Fraction fraction)
        {
            /*
              1       3      1*5 + 3*2     11
             ---  +  --- =  ----------- = ----
              2       5       2 * 5        10
             */
            int commonDenominator = this.Denominator * fraction.Denominator;
            int commonNumerator = this.Numerator * fraction.Denominator + fraction.Numerator * this.Denominator;

            this.Numerator = commonNumerator;
            this.Denominator = commonDenominator;
        }

        public Fraction Add(Fraction fractionLeft, Fraction fractionRight)
        {
            int numeratorNew = fractionLeft.numerator * fractionRight.denominator + fractionRight.numerator * fractionLeft.denominator;
            int denominatorNew = fractionLeft.Denominator * fractionRight.denominator;
            this.numerator = numeratorNew;
            this.denominator = denominatorNew;
            return this;
        }



        public void Mult(Fraction fraction)
        {
            this.Numerator *= fraction.Numerator;
            this.Denominator *= fraction.Denominator;
            this.Simplify();
        }

        public void Mult(int multiplier)
        {
            this.Numerator *= multiplier;
        }

        public void Simplify()
        {
            int tNumerator = this.Numerator;
            int tDenominator = this.Denominator;
            int n = 0;
            if (tDenominator % tNumerator == 0)
            {
                Denominator /= Numerator;
                Numerator = 1;
                Console.WriteLine($"Common steps for simplification: 1");

                return;
            }

            for (int i = 2; i < tNumerator; i++)
            {
                if (tNumerator % i == 0 && tDenominator % i == 0)
                {
                    tNumerator /= i;
                    tDenominator /= i;
                    i--;
                    n++;
                }
            }

            this.Numerator = tNumerator;
            this.Denominator = tDenominator;
            Console.WriteLine($"Coomon steps for simplification: {n}");
        }
    }
}
