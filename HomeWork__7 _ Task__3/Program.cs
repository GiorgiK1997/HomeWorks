namespace HomeWork__7___Tas;

    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter The number 1");
            int number = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();
            words.Add("girogi");
            words.Add("asasaxs");
            words.Add("ggiooffd");
            words.Add("weewwwewewewa");
            words.Add("hermaqw");
            words.Add("awerlp");
            foreach (var item in words.Where(x => x.Length == number))
            {
                Console.WriteLine(item);
            }         
        }
    }
