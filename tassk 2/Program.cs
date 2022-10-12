namespace tassk_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose option");
            Console.WriteLine(" + ");
            Console.WriteLine(" / ");
            Console.WriteLine(" - ");
            Console.WriteLine(" * ");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    if (num2 > num1)
                    {
                        result = num2 - num1;
                    }
                    else
                    {
                        result = num1 - num2;
                    }
                    break;
                case "*":
                    result = num1 * num2;
                    break;

                case "/":
                    if (num2 > num1)
                    {
                        if (num1 == 0)
                        {
                            Console.WriteLine("Cannot be divided by zero");
                        }
                        else
                        {
                            result = num2 / num1;
                        }
                    }
                    if (num1 > num2)
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot be divided by zero");
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                    break;
            }
            Console.WriteLine(result);
        }
    }
}