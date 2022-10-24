namespace HomeWork__8__Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "bayern";
            Print(word);
        }
        static void Print(string word)
        {
            if(word.Length > 1)
            {
                string modifiedWord = word.Substring(1);
                Print(modifiedWord);
                Console.WriteLine(word[0]);
            }
            else
            {
                Console.WriteLine(word); 
            }
        }

    }
    
}