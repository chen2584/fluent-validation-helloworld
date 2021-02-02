using System;
using System.Collections.Generic;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var customer = new Customer
            {
                FirstName = "Chen",
                LastName = "Semapat",
                Age = 20,
                Cats = new List<string>
                {
                    "Cat01",
                    null
                }
            };
            var validator = new CustomerValidator();
            var result = validator.Validate(customer);

            bool success = result.IsValid;
            var failures = result.Errors;

            foreach (var failure in failures)
            {
                Console.WriteLine(failure.ErrorMessage);
            }

            Console.WriteLine("Done!");
        }
    }
}
