using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_three
{
    public class point
    {
        public string Name;
        public int Start;
        public int End;
    }
    public class line
    {
        public string type;

        public line(string type,point p,color color)
        {
            if (p ==null)
            {
                point nwePoint = new point();
                nwePoint.Start = 50;
                nwePoint.End = 100;
                nwePoint.Name = "test";
            }
        }

    }
    public class color
    {
        public string Color;
    }
    public class circle
    {
        private int salary;

        private int calc()
        {
            return 500+salary;
        }

        public void show()
        {
            Console.WriteLine(calc());
        }
    }

}
