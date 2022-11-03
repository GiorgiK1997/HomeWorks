namespace HomeWork11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputFile = @"\GiorgiRepositories\HomeWork11\My file\CommSchool.txt";
            Console.WriteLine("Enter number line");
            var   line = int.Parse(Console.ReadLine());
            var lastLine = "";
            for (int i = 0; i < line; i++)
            {
                var writeText = Console.ReadLine();
                lastLine = writeText;

            }
            File.AppendAllText(inputFile, lastLine );
            StreamReader writer = File.OpenText(inputFile);
            Console.WriteLine(writer.ReadToEnd());
           

        }
    }
}