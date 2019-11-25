using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TestOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            s = s.ToLower();
            s = s.Replace(" ", "");

            Console.WriteLine("Hello, user " + s);
            Console.ReadKey();
        }
    }
}
