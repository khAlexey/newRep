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
            /*Point p1 = new Point(0, 0, '#');
            p1.Draw();
            Point p2 = new Point(1, 0, '#');
            p2.Draw();
            Point p3 = new Point(2, 0, '#');
            p3.Draw();
            Point p4 = new Point(3, 0, '#');
            p4.Draw();
            Point p5 = new Point(4, 0, '#');
            p5.Draw();*/

            HorizontalLine line = new HorizontalLine(0, 60, 20, '#');
            line.Draw();

            VertikalLine vline = new VertikalLine(0, 20, 61, '#');
            vline.Draw();

            Console.ReadLine();
        }
    }
}
