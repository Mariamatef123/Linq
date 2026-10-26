using System;
using System.Collections.Generic;

namespace FunctionalProgramming
{
    public static class ExtensionProcedural
    {
        public static IEnumerable<Employee> GetEmployeesWithId(int id)
        {
            var employees = Repository.LoadEmployees();//dependency(not pure) , hard to test,

            foreach (var employee in employees)
            {
                if (employee.Id == id)//imparative side effect, hard to test, not pure function
                {
                    yield return employee;
                }
            }
        }


        public static IEnumerable<Employee> GetEmployeesWithFirstName(string value)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.FirstName.Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithFirstNameStartsWith(string value)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.FirstName.StartsWith(value, StringComparison.OrdinalIgnoreCase))
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithFirstNameEndsWith(string value)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.FirstName.EndsWith(value, StringComparison.OrdinalIgnoreCase))
                {
                    yield return employee;
                }
            }
        }

    
        public static IEnumerable<Employee> GetEmployeesWithLastName(string value)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.LastName.Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithLastNameStartsWith(string value)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.LastName.StartsWith(value, StringComparison.OrdinalIgnoreCase))
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithLastNameEndsWith(string value)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.LastName.EndsWith(value, StringComparison.OrdinalIgnoreCase))
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithHireDate(DateTime date)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.HireDate.Date == date.Date)
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesHiredBefore(DateTime date)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.HireDate < date)
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesHiredAfter(DateTime date)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.HireDate > date)
                {
                    yield return employee;
                }
            }
        }


        public static IEnumerable<Employee> GetEmployeesWithGender(string value)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.Gender.Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    yield return employee;
                }
            }
        }


        public static IEnumerable<Employee> GetEmployeesWithDepartment(string value)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.Department.Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithDepartmentStartsWith(string value)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.Department.StartsWith(value, StringComparison.OrdinalIgnoreCase))
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithDepartmentEndsWith(string value)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.Department.EndsWith(value, StringComparison.OrdinalIgnoreCase))
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithHealthInsurance(bool value)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.HasHealthInsurance == value)
                {
                    yield return employee;
                }
            }
        }

   
        public static IEnumerable<Employee> GetEmployeesWithPensionPlan(bool value)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.HasPensionPlan == value)
                {
                    yield return employee;
                }
            }
        }

    
        public static IEnumerable<Employee> GetEmployeesWithSalary(decimal salary)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.Salary == salary)
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithSalaryGreaterThan(decimal salary)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.Salary > salary)
                {
                    yield return employee;
                }
            }
        }

        public static IEnumerable<Employee> GetEmployeesWithSalaryLessThan(decimal salary)
        {
            var employees = Repository.LoadEmployees();

            foreach (var employee in employees)
            {
                if (employee.Salary < salary)
                {
                    yield return employee;
                }
            }
        }
 
public static void PrintEmployees(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

    }
}
