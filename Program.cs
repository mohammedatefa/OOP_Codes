namespace Day_six_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber a = new ComplexNumber(2, 3);
            ComplexNumber b = new ComplexNumber(4, 1);

            ComplexNumber increment = a;
            Console.WriteLine($"Incremented a: {++increment}"); 
            Console.WriteLine($"Incremented a: {increment++}");

        }
    }
}