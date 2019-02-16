using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task3
{
    class Program
    {
        static void dfs(FileSystemInfo v, int cnt)
        {
            string pref = new string(' ', 4 * cnt);
            string print = pref + v.Name;
            Console.WriteLine(print);
            if (v.GetType() == typeof(DirectoryInfo))
            {
                var all = (v as DirectoryInfo).GetFileSystemInfos();
                foreach (var i in all)
                {
                    dfs(i, cnt + 1);
                }
            }
        }
        static void Main()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Aigerim\Documents\bitlab");
            dfs(dir, 0);
        }
    }
}
