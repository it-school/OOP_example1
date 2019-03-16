using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example1
{
    class Fraction
    {
        int numerator;
        int denominator;

        public int Numerator { get => numerator; set => numerator = value; }
        public int Denominator { get => denominator; set => denominator = (value != 0 ? value : 1); }

        public Fraction()
        {
            this.denominator = 1;
        }

        public Fraction(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }

        public Fraction(int numerator, int denominator) : this(numerator)
        {
            this.Denominator = denominator;
        }
        /*
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.Denominator = denominator;
        }
         */

        override public String ToString()
        {
            return "\n" + this.numerator + "\n---\n" + this.denominator;
        }

        public void Reverse()
        {
            int numerator = this.numerator;
            this.numerator = this.denominator;
            this.denominator = numerator;
        }

        public void Add(Fraction fraction)
        {
            /*
              1       3      5 + 6    11
             ---  +  --- =  ------ = ----
              2       5       10      10
             */
            int commonDenominator = this.denominator * fraction.denominator;
            int commonNumerator = this.numerator * fraction.denominator + fraction.numerator * this.denominator;

            this.numerator = commonNumerator;
            this.denominator = commonDenominator;
        }

        public void Mult(Fraction fraction)
        {
            this.numerator *= fraction.numerator;
            this.denominator *= fraction.denominator;
        }

        public void Mult(int multiplier)
        {
            this.numerator *= multiplier;
        }

        public void Simplify()
        {
            int tNumerator = this.numerator;
            int tDenominator = this.denominator;
            int n = 0;
            if (tDenominator % tNumerator == 0)
            {
                denominator /= numerator;
                numerator = 1;
                Console.WriteLine($"Coomon steps for simplification: 1");

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

            this.numerator = tNumerator;
            this.denominator = tDenominator;
            Console.WriteLine($"Coomon steps for simplification: {n}");
        }
    }
}
