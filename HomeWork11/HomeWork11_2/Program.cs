namespace HomeWork11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var saveFile = @"C:\GiorgiRepositories\HomeWork11_2\multiplication.txt";
            Console.WriteLine("Enter the number");
            var result = 0;
            var Number= int.Parse(Console.ReadLine()); 
            ;
            for (int x = 1; x <=Number; x++)
            {
                result = x * Number;
                Console.WriteLine(" {0} * {1} = {2} ", x, Number, (result));
                File.AppendAllText(saveFile, saveFile);
            }
            
        }
    }

}