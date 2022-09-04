using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee(1, "aa", new DateTime(2005, 5, 5), 2500);
            Console.WriteLine(emp.ConvertString());
            
            Console.WriteLine(emp.CalculateTax());
            Console.ReadLine();


        }
    }
}
