using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public abstract class FileWorker
    {
        public int MaxSize { get; set; }
        public abstract string FileExtension { get; set; }
        public virtual void Delete()
        {
            Console.WriteLine("i can delete" + this.FileExtension + " wiht max storage " + this.MaxSize);
        }

        public virtual void Edit()
        {
            Console.WriteLine("i can edit" + this.FileExtension + " wiht max storage ");
        }

        public virtual void Read()
        {
            Console.WriteLine("i can read" + this.FileExtension + " wiht max storage");
        }

        public virtual void Write()
        {
            Console.WriteLine("i can write" + this.FileExtension + " wiht max storage ");
        }
    }

    public class Gfile : FileWorker
    {
        public override string FileExtension { get; set; }
        public override void Read()
        {
            Console.WriteLine("GFile Read" + this.FileExtension + " wiht max storage " + this.MaxSize);
        }

        public override void Write()
        {
            Console.WriteLine("GFile Write" + this.FileExtension + " wiht max storage " + this.MaxSize);
        }
    }
}