namespace Week_6__Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Num = new int[10];
            Num[0] = 4;
            Num[1] = 7;
            Num[2] = 8;
            Num[3] = 6;
            Num[4] = 5;
            Num[5] = 10;
            Num[6] = 9;
            Num[7] = 1;
            Num[8] = 2;
            Num[9] = 3;
                

            var orderBy = Num.OrderByDescending(x => x);
            foreach (var item in orderBy . Take(3))
            {
                Console.WriteLine(item);
              
                
            }

           
        }
    }
}