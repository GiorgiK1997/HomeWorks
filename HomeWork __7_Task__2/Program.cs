namespace HomeWork___7_Task__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int winScore = 3;
            int lostScore = 0;
            int drawScore = 1;
            Console.WriteLine(" enter the winer game ");
            int winGame = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the lost game ");
            int lostGame = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the draw game");
            int drawGame = int.Parse(Console.ReadLine());
            int result = (winScore * winGame)  + (drawScore * drawGame);
            Console.WriteLine("Your score " + result);
         }
    }
}