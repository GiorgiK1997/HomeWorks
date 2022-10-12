namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i * number);
            }


        }
    }
}