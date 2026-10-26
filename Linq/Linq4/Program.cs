using Shared;

namespace Linq4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var employees = Repository.LoadEmployees();//this array has count
            var femaleEmp = employees
                .Where(e => e.Gender == "Female");//not stored in memory
            femaleEmp.PrintEmployees();

            var empsSalaryGreaterThan50000 = employees
                .Where(e => e.Salary > 50000);

            empsSalaryGreaterThan50000.PrintEmployees();

            var femaleEmpsInHrDepartement= femaleEmp
                .Where(e => e.Department == "hr");
            femaleEmpsInHrDepartement.PrintEmployees();
        }
    }
}
