using Shared;

namespace SelectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample2();
        }

        private static void RunExample1()
        {
            string[] names = { "I Love ASP.NET Core", "I Like Sql Server", "in General i love programming" };
            var result = names.SelectMany(n => n.Split(' '));
            foreach (var c in result)
            {
                Console.WriteLine(c);
            }
        }
        private static void RunExample2()
        {
            var employees = Repository.LoadEmployees();
            var skills = employees.SelectMany(e => e.Skills.Distinct());//unique skills of all employees
            var result =(from employee in employees
                         from skill in employee.Skills.Distinct()
                         select skill).Distinct();
            foreach (var c in skills)
            {
                Console.WriteLine(c);
            }
        }
    }
}
