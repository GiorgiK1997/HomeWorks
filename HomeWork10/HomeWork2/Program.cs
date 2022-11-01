namespace HomeWork2
{
    public class Program
    {
        static void Main(string[] args)
        {

            IFinanceOperation finCompany = new Bank();
            if (finCompany.CheckUserHistory())
            {
                double totalAmount = finCompany.CalculateLoanPercent(10, 2000);
                Console.WriteLine(totalAmount);
            }
        }
    }
}