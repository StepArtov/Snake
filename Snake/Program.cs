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
            Point p1 = new Point(1, 5, '*');
            p1.Draw();

            Point p2 = new Point(4, 4, '*');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(2);
            numList.Add(5);

            Console.ReadLine();
        }


    }
}