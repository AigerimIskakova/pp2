using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks2
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = System.IO.File.ReadAllText(@"C:\Users\Aigerim\Documents\pp2\week2\task2\input.txt");
            string[] nums = folder.Split();
            int cnt = 0;
            string ans = "";
            for (int i = 0; i < nums.Length; i++)
            {
                bool good = true;
                int x = int.Parse(nums[i]);
                if (x == 1 || x == 0) good = false;
                for (int j = 2; j * j <= x; j++)
                {
                    if (x % j == 0) good = false;
                }
                if (good)
                {
                    ans = ans + nums[i];
                    ans = ans + " ";
                }
            }
            System.IO.File.WriteAllText(@"C:\Users\Aigerim\Documents\pp2\week2\task2\output.txt", ans);

        }
    }
}