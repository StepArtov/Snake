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
        static void Main(string[] args)dsfsdfsdfsdf
        {

            //Console.SetBufferSize(80, 30);


            HorizontalLine lineXLeft = new HorizontalLine(1, 118, 1, 'e');
            HorizontalLine lineXRight = new HorizontalLine(1, 118, 30, 'e');
            VerticalLine lineYLeft = new VerticalLine(0, 30, 118, 'e');
            VerticalLine lineYRight = new VerticalLine(0, 30, 1, 'e');
            lineXLeft.Draw();
            lineXRight.Draw();
            lineYLeft.Draw();
            lineYRight.Draw();


            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(600);
            snake.Move();
            Thread.Sleep(600);

            Console.ReadLine();
        }


    }
}
