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
            Console.SetWindowSize(80, 30);
            Console.SetBufferSize(80, 30);

            HorizontalLine upline = new HorizontalLine(0, 70, 0, '#');
            HorizontalLine downline = new HorizontalLine(0, 70, 20, '#');
            VertikalLine leftline = new VertikalLine(0, 20, 0, '#');
            VertikalLine rightline = new VertikalLine(0, 20, 70, '#');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();

            Point p = new Point(4, 5, '*');
            p.Draw();

            Console.ReadLine();
        }
    }
}
