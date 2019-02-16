using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static string[] make(string[] arr, int n)
        {
            string[] ret = new string[n * 2];
            for (int i = 0; i < n; i++)
            {
                ret[i * 2] = arr[i];
                ret[i * 2 + 1] = arr[i];
            }
            return ret;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // read
            int n = int.Parse(s); // parse
            string nums = Console.ReadLine(); // read 2 line
            string[] arr = nums.Split(); // split

            string[] ans = make(arr, n);
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write(ans[i] + " ");
            }
            Console.ReadKey();
        }
    }
}