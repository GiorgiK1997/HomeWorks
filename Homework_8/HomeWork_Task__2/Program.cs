namespace HomeWork_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberofSocks = CalculateSocks("abcdefghab");
            Console.WriteLine(numberofSocks);
        }
        static int CalculateSocks(string word)
        {

            int result = 0;
            var grouped = word.GroupBy(x => x);
            foreach (var group in grouped)
            {
                if(group.Count() %2 == 0)
                {
                    result = result + group.Count() / 2;
                }
                else
                {
                    
                    result = result + (group.Count() - 1) / 2;
                }
            }
            return result;

        }
    }
}