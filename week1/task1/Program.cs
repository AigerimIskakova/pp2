using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // read line 
            int n = int.Parse(s);   // get int from line
            string nums = Console.ReadLine(); // read second line
            string[] arr = nums.Split(); // spline second line
            int cnt = 0; // number of primes
            int[] ans = new int[n]; // stores primes
            for (int i = 0; i < arr.Length; ++i)
            {
                bool good = true; // check
                int per = int.Parse(arr[i]);
                if (per == 1) continue;
                for (int j = 2; j * j <= per; ++j)
                {
                    if (per % j == 0) good = false;
                }
                if (good)
                {
                    ans[cnt] = per; // if its prime insert
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < cnt; ++i)
            {
                Console.Write(ans[i] + " "); // write
            }
            Console.ReadKey();
        }
    }
}
