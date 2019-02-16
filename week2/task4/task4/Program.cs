using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Aigerim\Documents\pp2\week1\task3\los.txt";
            File.Create(path).Close();

            string path1 = @"C:\Users\Aigerim\Documents\pp2\week1\task3";
            FileInfo f = new FileInfo(path);
            DirectoryInfo dirInfo = new DirectoryInfo(path1);
            if (f.Exists && dirInfo.Exists)
            {
                f.CopyTo(path1 + @"\Copied.txt", true);
                f.Delete();
            }
            else Console.WriteLine("&(");
            //File.Delete(@"C:\Users\Aigerim\Documents\pp2\week1\task3\los.txt");
        }
    }
}
