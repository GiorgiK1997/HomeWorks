namespace CommSchool_Week5_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array_1 = new int[10];

            Random random = new Random();
            for (int i = 0; i < array_1.Length; i++)
            {
                array_1[i] = random.Next(1000);
                Console.WriteLine(array_1[i]);
            }



            List<int> listEven = new List<int>();
            Console.WriteLine("enter  even numbers the second array");
            for (int i = 0; i < array_1.Length; i++)
            {
                if (array_1[i] % 2 == 0)
                {
                    listEven.Add(array_1[i]);
                }
            }

            List<int> listOdd = new List<int>(); ;
            Console.WriteLine("enter odd numbers the third array");
            for (int i = 0; i < array_1.Length; i++)
            {
                if (i % 2 != 0)
                {
                    listOdd.Add(array_1[i]);
                }
            }



            Console.WriteLine("Even List");
            foreach (var item in listEven)
            {
                Console.WriteLine(item);
            }
        }

    }
}
