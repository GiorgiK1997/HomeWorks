namespace CommSchool__1
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter First Number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"X is {x} and Y is {y}");
            int z = x;
            x = y;
            y = z;

            Console.WriteLine($"X is {x} and Y is {y}");
        }
    }
}