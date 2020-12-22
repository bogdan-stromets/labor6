using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            if (n > q)
            {
                Console.WriteLine("YES");
            }
            else 
                Console.WriteLine("NO");
            Console.ReadKey();
        }
    }
}
