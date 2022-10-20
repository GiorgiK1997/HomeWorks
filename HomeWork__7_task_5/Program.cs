namespace HomeWork__7_task_5


{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] work = new int[7];
            int result = 0;
            int weekendRate = 20;
            int normRate = 10;
            int overTimeRate = 15;
            for (int i = 0; i < work.Length; i++)
            {
                work[i] = int.Parse(Console.ReadLine());
                if (i <= work.Length - 3)
                {
                    if (work[i] <= 8)
                    {
                        result = result + (work[i] * normRate);
                    }
                    if (work[i] > 8)
                    {
                        result = result + (work[i] - 8) * overTimeRate + (8 * normRate);
                    }
                }
                else
                {
                    result = result + (weekendRate * work.ElementAt(i));
                }

            }
            Console.WriteLine(result);
        }
    }
}