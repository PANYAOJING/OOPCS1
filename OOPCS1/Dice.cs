using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS1
{
    class Dice
    {
        int side;
        public Dice(int x)
        {
            side = x;
        }
        public int FaceUp()
        {
            return side;
        }
        public void Roll()
        {
            Random rnd = new Random();
            side = rnd.Next(6);
            System.Threading.Thread.Sleep(100);
        }
    }
}
