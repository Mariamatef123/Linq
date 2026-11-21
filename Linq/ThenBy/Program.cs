using SharedForSorting;

namespace ThenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var employees = Repository.LoadEmployees();
            var empsFNameStartingWithM = employees
                .Where(e=>e.FirstName.StartsWith("M"))
                .OrderBy(e => e.FirstName)
                .ThenByDescending(e => e.LastName);//returns IOrederedEnumerable<Employee> which implements IEnumerable<Employee>
            empsFNameStartingWithM.PrintEmployees();  
        }
    }
}
