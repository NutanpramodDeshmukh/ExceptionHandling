using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeDetermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age ");
            int age = Convert.ToInt32(Console.ReadLine());
            Person P = new Person(age);
            P.Category();
            Console.ReadKey();
        }
    }
}
