using System;

namespace FunctionalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunProcedural01();
            Console.WriteLine("================");
            RunFunctional01();
        }
        static void RunProcedural01()
        {
            ExtensionProcedural.PrintEmployees(
    ExtensionProcedural.GetEmployeesWithId(1)
);

            ExtensionProcedural.PrintEmployees(
                ExtensionProcedural.GetEmployeesWithFirstNameStartsWith("M")
            );

            ExtensionProcedural.PrintEmployees(
                ExtensionProcedural.GetEmployeesWithLastNameEndsWith("y")
            );

            ExtensionProcedural.PrintEmployees(
                ExtensionProcedural.GetEmployeesWithSalaryGreaterThan(10000m)
            );

            ExtensionProcedural.PrintEmployees(
                ExtensionProcedural.GetEmployeesWithHealthInsurance(true)
            );
        }
        static void RunFunctional01()
        {
            var employees = Repository.LoadEmployees();
            var result = ExtensionFunctional01.Filter(
                employees,
                e =>e.FirstName.ToLowerInvariant()=="ma"
            );
            //high order function -> function that takes another function as an argument or return a function
            ExtensionFunctional01.PrintEmployees(result);
        }
        static void RunFunctional02()
        {
            var employees = Repository.LoadEmployees();
            var result = employees.Filter(
                e => e.FirstName.ToLowerInvariant() == "ma"
            );
            //high order function -> function that takes another function as an argument or return a function
            employees.PrintEmployees();
        }
    }
}
