using Shared;

namespace Join
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            RunGroupJoinQuerySyntax();
        }

        private static void RunJoin()
        {
            var employees = Repository.LoadEmployees();
            var departments = Repository.LoadDepartments(); 
            var result = employees.Join(departments,
                e => e.DepartmentId,
                d => d.Id,
                (e, d) => new EmployeeDto
                { 
                    FullName = e.FirstName + " " + e.LastName,
                    DepartmentName = d.Name 
                });
            //employee -> outer sequence
            //department -> inner sequence
            foreach (var employee in result)
            {
                Console.WriteLine($"Employee: {employee.FullName}, Department: {employee.DepartmentName}");
            } 

        }
      
        private static void RunJoinQuerySyntax()
        {
            var employees = Repository.LoadEmployees();
            var departments = Repository.LoadDepartments();
            var result = from employee in employees
                         join department in departments
                         on employee.DepartmentId equals department.Id
                         select new EmployeeDto
                         {
                             FullName = employee.FirstName + " " + employee.LastName,
                             DepartmentName = department.Name
                         };
            //employee -> outer sequence
            //department -> inner sequence
            foreach (var employee in result)
            {
                Console.WriteLine($"Employee: {employee.FullName}, Department: {employee.DepartmentName}");
            }

        }
        private static void RunGroupJoin()
        {
            var employees = Repository.LoadEmployees();
            var departments = Repository.LoadDepartments();
            var result = departments.GroupJoin(
                employees,
                d => d.Id,
                e => e.DepartmentId,
                (d, e) => new GroupJoinResult
                {
                    DepartmentName = d.Name,
                    Employees = e.Select(emp => emp.FirstName + " " + emp.LastName).ToList()
                });
            foreach (var item in result)
            {
                Console.WriteLine($"{item.DepartmentName}");
                foreach (var name in item.Employees)
                {
                    Console.WriteLine($" - {name}");
                }
            }

        }
        private static void RunGroupJoinQuerySyntax()
        {
            var employees = Repository.LoadEmployees();
            var departments = Repository.LoadDepartments();
            var result = from department in departments
                         join employee in employees
                         on department.Id equals employee.DepartmentId
                         group employee by department into g
                         select g;
                        
            foreach (var g in result)
            {
                Console.WriteLine($"{g.Key.Name}");
                foreach (var name in g)
                {
                    Console.WriteLine($" - {name}");
                }
            }

        }
    }
}   
