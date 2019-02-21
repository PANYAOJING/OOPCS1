using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS1
{
    class Hex
    {
        string hexa_num;
        public Hex(string s)
        {
            hexa_num = s;
        }
        public string GetNum()
        {
            return hexa_num;
        }
        public string ToBinary()
        {
            string result = "";
            string[] tobinary = { "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111", "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
            char[] hex = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            for (int i = hexa_num.Length-1; i >= 0; i--)
            {
                char ch = hexa_num[i];
                int index = Array.IndexOf(hex, ch);
                result = tobinary[index] + result;
            }
            return result;
        }
        public double ToDecimal()
        {
            double result = 0;
            char[] hex = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            for (int i = hexa_num.Length - 1; i >= 0; i--)
            {
                char ch = hexa_num[i];
                double index = Array.IndexOf(hex, ch);
                result += index * Math.Pow(16, hexa_num.Length - 1 -i );
            }
            return result;
        }
    }
}
