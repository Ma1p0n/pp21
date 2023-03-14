using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            int diff = sum - b;
            int mult = a * b;
            int div = a / b;
            Console.WriteLine(sum + " " + diff + " " + mult + " " + div);
        }
    }
}
