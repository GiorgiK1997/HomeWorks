using System.Linq;


namespace week_6__task_2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listNumber = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                int randNumber = random.Next(10);
                listNumber.Add(randNumber);
                Console.WriteLine(randNumber);
                if(randNumber % 2 == 0)
                {
                    Console.WriteLine(randNumber);
                }
            }


            Console.WriteLine("----------- GROUPS ---------------------");

            var groupedNumbers = listNumber.GroupBy(x => x);
            foreach (var item in groupedNumbers)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($".......... {item.Key}  .........{item.Count()}........{item.Sum()}");


            }


        }



    }
}