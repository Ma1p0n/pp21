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
            Console.WriteLine("Введите а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            int diff = sum - b;
            int mult = a * b;
            int div = a / b;
            Console.WriteLine(sum + " " + diff + " " + mult + " " + div);
        }
    }
}
