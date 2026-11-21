using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedForSorting
{
    public static class Repository
    {
        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Employee { EmployeeNo="2017-FI-1343",Id = 1, FirstName = "John", LastName = "Doe", HireDate = new DateTime(2020, 1, 15), Gender = "Male", Department = "IT", HasHealthInsurance = true, HasPensionPlan = true, Salary = 60000 },
                new Employee { EmployeeNo="2017-FI-1345",Id = 2, FirstName = "Jane", LastName = "Smith", HireDate = new DateTime(2019, 3, 10), Gender = "Female", Department = "HR", HasHealthInsurance = true, HasPensionPlan = false, Salary = 55000 },
                new Employee {EmployeeNo="2016-FI-1343", Id = 3, FirstName = "Michael", LastName = "Johnson", HireDate = new DateTime(2021, 5, 20), Gender = "Male", Department = "Finance", HasHealthInsurance = false, HasPensionPlan = true, Salary = 70000 },
                new Employee { EmployeeNo="2017-FL-1343",Id = 4, FirstName = "Emily", LastName = "Davis", HireDate = new DateTime(2018, 7, 5), Gender = "Female", Department = "Marketing", HasHealthInsurance = true, HasPensionPlan = true, Salary = 65000 },
                new Employee { EmployeeNo="2014-FK-1323",Id = 5, FirstName = "David", LastName = "Wilson", HireDate = new DateTime(2022, 2, 28), Gender = "Male", Department = "Sales", HasHealthInsurance = false, HasPensionPlan = false, Salary = 50000 }
            };
        }
    }
}
