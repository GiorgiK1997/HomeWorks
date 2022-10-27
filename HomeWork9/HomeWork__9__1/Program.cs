namespace HomeWork__9__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher dato = new Teacher();
            dato.IsCertifaed = true;
            string result  = dato.ChekStudent(Subject.Literature);
            Console.WriteLine(result);

        }
    }
}