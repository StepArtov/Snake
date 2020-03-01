using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        const int WIGHT = 119;
        const int HEIGHT = 30;

        static void Main(string[] args)
        {
            Console.SetWindowSize(WIGHT + 2, HEIGHT + 2);
            Console.SetBufferSize(WIGHT + 2, HEIGHT + 2);


            Point p = new Point();

            HorizontalLine line1 = new HorizontalLine(1, 119, 0, '*');
            HorizontalLine line2 = new HorizontalLine(1, 119, 31, '*');
            VerticalLine line3 = new VerticalLine(0, 30, 120, '*');
            VerticalLine line4 = new VerticalLine(0, 30, 0, '*');
            line1.Draw();
            line2.Draw();
            line3.Draw();
            line4.Draw();

            Point p1 = new Point(5, 3, '#');
            p1.Draw();
            Console.ReadLine();
        }


    }
}