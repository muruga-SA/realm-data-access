using System;
using System.Linq;
using System.Collections.Generic;

namespace RealmConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var repository = new EmployeeRepository();

            // Add 10 employees
            var employees = new Bogus.Faker<Employee>()
                .RuleFor(x => x.Id, x => ++x.IndexVariable)
                .RuleFor(x => x.Name, x => x.Name.FullName())
                .RuleFor(x => x.Phone, x => x.Phone.PhoneNumber())
                .Generate(10);

            repository.AddEmployees(employees);

            // Read employees count
            var count = repository.CountEmployees();

            System.Console.WriteLine($"Employee Count: {count}");
        }
    }
}
