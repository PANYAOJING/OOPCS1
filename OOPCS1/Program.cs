using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dice dice = new Dice(2);
            //Console.WriteLine($"The faceup number is: {dice.FaceUp()}");
            //dice.Roll();
            //Console.WriteLine($"The faceup number is: {dice.FaceUp()}");

            //Console.WriteLine("Pls enter a hexadecimal number: ");
            //string s = Console.ReadLine();
            //Hex hex = new Hex(s);
            //Console.WriteLine($"Hexadecimal: {hex.GetNum()}");
            //Console.WriteLine($"Binary: {hex.ToBinary()}");
            //Console.WriteLine($"Decimal: {hex.ToDecimal()}");

            Console.WriteLine("Pls enter a Numerator: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Pls enter a Denomitator: ");
            int den = int.Parse(Console.ReadLine());
            Rational r1 = new Rational(num, den);
            Rational r2 = new Rational(2, 5);
            Rational r;

            r1.Print();
            Console.Write("TIMES ");
            r2.Print();
            r = r1.Multiply(r2);
            Console.Write("is ");
            r.Print();
            Console.WriteLine();

            r1.Print();
            Console.WriteLine("divides ");
            r2.Print();
            r = r1.Divide(r2);
            Console.Write("is ");
            r.Print();
        }
    }
}
