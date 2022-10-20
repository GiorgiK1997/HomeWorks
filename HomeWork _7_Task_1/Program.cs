namespace HomeWork__7_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string word = Console.ReadLine();
            bool result = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[0])
                {
                    result = false;
                }
                
            }
            if(result == false)
            {
                Console.WriteLine(" you lost");
            }
            else
            {
                Console.WriteLine(" you win jakpot");
            }
           
            

        }
    }
}