using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS1
{
    class Rational
    {
        int Numerator;
        int Denominator;
        public Rational(int N,int D)
        {
            Numerator = N;
            Denominator = D;
        }
        public void Reduce()
        {
            int factor = 1;
            for(int i = 2; i <= Math.Min(Numerator, Denominator); i++)
            {
                if (Numerator / i == 0 && Denominator / i == 0)
                {
                    factor = i;
                }
            }
            Numerator /= factor;
            Denominator /= factor;
        }
        public void Print()
        {
            Console.Write($"{Numerator}/{Denominator}");
        }
        public Rational Multiply(Rational r)
        {
            Numerator *= r.Numerator;
            Denominator *= r.Denominator;

            Rational NEW_r = new Rational(Numerator, Denominator);
            NEW_r.Reduce();
            return NEW_r;
        }
        public Rational Divide(Rational r)
        {
            Numerator *= r.Denominator;
            Denominator *= r.Numerator;
            Rational NEW_r = new Rational(Numerator, Denominator);
            NEW_r.Reduce();
            return NEW_r;
        }
    }
}
