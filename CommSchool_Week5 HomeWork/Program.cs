namespace CommSchool_Week5_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int x = int.Parse(Console.ReadLine());
            int result = x % 5;
            Console.WriteLine(result);

            string answer = result > 0 ? "no" : "yes";
            Console.WriteLine(answer);
        }
    }
}