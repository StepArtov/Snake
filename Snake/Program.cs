using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizontalLine line1 = new HorizontalLine(1, 118, 0, '*');
            HorizontalLine line2 = new HorizontalLine(1, 118, 29, '*');
            VerticalLine line3 = new VerticalLine(0, 28, 118, '*');
            VerticalLine line4 = new VerticalLine(0, 28, 0, '*');
            line1.Draw();
            line2.Draw();
            line3.Draw();
            line4.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(118, 28, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat( food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(150);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key);

                }
            }
        }//Console.ReadLine();
    }
}