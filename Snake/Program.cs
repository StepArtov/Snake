using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();

            HorizontalLine line = new HorizontalLine();
            line.Draw();

            Console.ReadLine();
        }


    }
}