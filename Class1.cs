using System;
using System.Collections.Generic;

namespace GestionareAngajati
{

    public class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int id, double salary)
        {
            Name = name;
            ID = id;
            Salary = salary;
        }

        public virtual double CalculateAnnualSalary()
        {
            return Salary * 12;
        }

        public virtual void AfisareDetalii()
        {
            Console.WriteLine($"[Employee] ID: {ID}, Name: {Name}, Monthly Salary: {Salary}");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public double Bonus { get; set; }

        public FullTimeEmployee(string name, int id, double salary, double bonus)
            : base(name, id, salary)
        {
            Bonus = bonus;
        }

        public override double CalculateAnnualSalary()
        {
            return (Salary * 12) + Bonus;
        }

        public override void AfisareDetalii()
        {
            Console.WriteLine($"[Full-Time] ID: {ID}, Name: {Name}, Monthly Salary: {Salary}, Bonus: {Bonus}, Annual Salary: {CalculateAnnualSalary()}");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }

        public PartTimeEmployee(string name, int id, double hourlyRate)
            : base(name, id, 0)
        {
            HourlyRate = hourlyRate;
        }

        public override double CalculateAnnualSalary()
        {

            return HourlyRate * 20 * 52;
        }

        public override void AfisareDetalii()
        {
            Console.WriteLine($"[Part-Time] ID: {ID}, Name: {Name}, Hourly Rate: {HourlyRate}, Annual Salary: {CalculateAnnualSalary()}");
        }
    }

}