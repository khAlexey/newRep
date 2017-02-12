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
            Point p1 = new Point(0, 0, '#');
            p1.Draw();
            Point p2 = new Point(1, 0, '#');
            p2.Draw();
            Point p3 = new Point(2, 0, '#');
            p3.Draw();
            Point p4 = new Point(3, 0, '#');
            p4.Draw();
            Point p5 = new Point(4, 0, '#');
            p5.Draw();

            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);
            pointList.Add(p4);
            pointList.Add(p5);

            foreach(Point point in pointList)
            {
                point.Draw();
            }

            List<char> symList = new List<char>();
            symList.Add('/');
            symList.Add('/');
            symList.Add('-');

            foreach(char sym in symList)
            {   
                Console.WriteLine(sym);
            }

            /*List<char> charList = new List<char>();
            charList.Add('#');
            charList.Add('#');
            charList.Add('#');
            charList.Add('#');
            int count = 0;

            foreach (char i in charList)
            {
                Point p = new Point(count, 0, charList[count]);
                p.Draw();
                count++;
            }*/

            Console.ReadLine();
        }
    }
}
