namespace HomeWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var file = new Gfile();
            file.MaxSize = 512;
            file.FileExtension = "JPEG";

            file.Write();
            file.Read();
            file.Edit();
            file.Delete();
        }
    }
}
