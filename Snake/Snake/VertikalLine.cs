using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertikalLine
    {
        List<Point> pList;

        public VertikalLine(int ytop, int ylow, int x, char sym)
        {
            pList = new List<Point>();
            for(int y = ytop; y <= ylow; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
