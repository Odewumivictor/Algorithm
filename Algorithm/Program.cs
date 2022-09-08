using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 7, 2, 6, 15, 54, 10, 23 };
            Console.WriteLine(myNumbers.Max()); 
            Console.WriteLine(myNumbers.Min()); 
            Console.WriteLine(myNumbers.Sum()); 
        }
    }
}
