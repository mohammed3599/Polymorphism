using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class Employee
    {
        public string name;
        public double salary;

        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public abstract double CalculateBonus();
    }

    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, double salary) : base(name, salary)
        {
        }

        public override double CalculateBonus()
        {
            return  300;
        }
    }

    internal class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string name, double salary) : base(name, salary)
        {
        }

        public override double CalculateBonus()
        {
            return  100;
        }
    }
}
