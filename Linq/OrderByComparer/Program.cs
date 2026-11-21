using SharedForSorting;

namespace OrderByComparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> employees = Repository.LoadEmployees();
            IOrderedEnumerable<Employee> orderedEmployees = employees.OrderBy(e => e, new EmployeeComparer());
            orderedEmployees.PrintEmployees();
        }
    }
}
