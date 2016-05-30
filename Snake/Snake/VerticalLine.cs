using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine (int yUp, int yDown, int x, char symb)
        {
            pList = new List<Point>();

            for (int y = yUp; y<=yDown; y++)
            {
                Point p = new Point(x, y, symb);
                pList.Add(p);
            }
        }

        public void DrawVertical()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
