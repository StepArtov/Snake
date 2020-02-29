using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;
        public HorizontalLine()
        {
            pList = new List<Point>();
            Point p1 = new Point(1, 5, '*');
            Point p2 = new Point(2, 5, '*');
            Point p3 = new Point(3, 5, '*');
                       
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            


        }

        public void Draw()
        {
            foreach (Point p in pList )
            {
                p.Draw();
            }
        }
          
    }
}
