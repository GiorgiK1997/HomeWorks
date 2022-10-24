namespace HomeWork_8__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var word1 = "multiplication";
            var word2 = "substraction";
            string result = "";
            int maxLength = word1.Length > word2.Length ? word1.Length : word2.Length;
            for (int i = 0; i < maxLength; i++)
            {
                
                int index1 = word1.Length - i - 1;
                int index2 = word2.Length - i - 1;
                if (index1 >= 0 && index2 >= 0)
                {
                    char a = word1[index1];
                    char b = word2[index2];
                    bool isEqual = a == b;
                    if (isEqual != true)
                    {

                        break;
                    }
                    else
                    {
                        result = result + a;
                    }
                }
                else
                {
                    break;
                }
 
            }
            Console.WriteLine(result);

        }
      
    }
}