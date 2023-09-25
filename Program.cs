using System.Reflection.Metadata;

namespace Day_fourandFive_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, polymorphism!");
        }
    }
    public class shape
    {
        public int x;
        public int y;

        public shape(int x,int y)
        {
            this.x=x;
            this.y=y;  
        }

        public virtual void  display()
        {
            Console.WriteLine($"the x is{x} and y is {y}");
        }
    }
    public class circle:shape
    {
        public int radiuse;
        public circle(int radiuse) : base(1, 2)
        {

            this.radiuse = radiuse; 

        }
        public void area()
        {
            double area = (22 / 7) * Math.Sqrt(radiuse);
            Console.WriteLine(area);
        }
        public void area(int radius)
        {
            double area = (22 / 7) * Math.Sqrt(radiuse);
            Console.WriteLine(area);
        }

        public override void display()
        {
            base.x += 1;
            base.y += 2;
            Console.WriteLine($"the x is{x} and y is {y}");

        }
    }
    public class rect : shape
    {
        public rect() : base(1, 2)
        {

        }
    }

    public class ellipse : circle
    {
        public ellipse() : base(10)
        {

        }
        public new void display()
        {
            Console.WriteLine("we are in ellipse sahpe");
        } 
    }

}