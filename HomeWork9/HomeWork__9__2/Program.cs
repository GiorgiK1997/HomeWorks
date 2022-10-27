namespace HomeWork__9__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company Tbc = new Company();
            Tbc.IsDomestic = true;
            int pct = 400;
            int result = Tbc.GetTaxRateAmount(pct);
            Console.WriteLine(result);
            Console.WriteLine("_____________");
            int pct1 = 600;
            Company Google = new Company();
            Google.IsDomestic = false;
            int result1 = Google.GetTaxRateAmount(pct1);
            Console.WriteLine(result1);


            
            Employee dato = new Employee();
            dato.FirstName = "Dato";
            dato.LastName = "Tsereteli";
            dato.Position = EnumPosition.Manager;
            dato.WorkedHours = new int[7] { 8, 8, 8, 8, 8, 13, 0 };
            int averageSalary = dato.GetAverageSalary();
            Console.WriteLine(averageSalary);

        }
    }
}