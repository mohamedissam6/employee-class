using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2
{
    internal class employee
    {
        private int Number;
        private string Name;
        private DateTime DateofhireDate;
        private int Salary;

        public int number { get; set; }
        public string name { get; set; }
        public DateTime dateofhireDate { get; set; }
        public int salary { get; set; }


        public employee (int number, string name, DateTime dateofhireDate, int salary)
        {
            Number = number;
            Name = name;
            DateofhireDate = dateofhireDate;
            Salary = salary;
        }

        public string ConvertString()
        {
            return ($"Number : {Number}\nName : {Name}\nDate of hire : {DateofhireDate}\nSalary : {Salary}");
        }

        public double CalculateTax()
        {
            return (0.1*(Convert.ToDouble(Salary)));
        }

    }
}
