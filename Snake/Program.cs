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

            HorizontalLine line1 = new HorizontalLine(1, 118, 0, '*');
            HorizontalLine line2 = new HorizontalLine(1, 118, 29, '*');
            VerticalLine line3 = new VerticalLine(0, 28, 118, '*');
            VerticalLine line4 = new VerticalLine(0, 28, 0, '*');
            line1.Draw();
            line2.Draw();
            line3.Draw();
            line4.Draw();
            Console.ReadLine();
        }


    }
}