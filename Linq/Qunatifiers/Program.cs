using Shared;

namespace Qunatifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // RunAnyDemo();
            RunContains();
        }
        private static void RunAnyDemo()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++");
            Console.WriteLine("RunAny()");
            Console.WriteLine("++++++++++");
            Console.WriteLine();
            var emps = Repository.LoadEmployees();
            //complexity is O(n)
            // Check if There is an Emp with name starts with jo
            var res1 = emps.Any(x=> x.FirstName.StartsWith("jo",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Check if There is an Emp with name starts with jo {res1}");

            // Check if There is an Emp with salary less than 10,000
            var res2 = emps.Any(x => x.Salary < 100000);
            Console.WriteLine($"Check if There is an Emp with salary less than 10,000 {res2}");
        }
        private static void RunAllDemo()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++");
            Console.WriteLine("RunAll()");
            Console.WriteLine("++++++++++");
            Console.WriteLine();
            var emps = Repository.LoadEmployees();
            // Check if All emps have C# listed in thier skills
            var res1 = emps.All(x => x.Skills.Any(s=>s=="C#"));
            Console.WriteLine($"Check if All emps have C# listed in thier skills {res1}");

        }
        private static void RunQuerySyntax()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++");
            Console.WriteLine("RunQuerySyntax()");
            Console.WriteLine("++++++++++");
            Console.WriteLine();
            var emps = Repository.LoadEmployees();

            var q1 = from emp in emps
                     where emp.Skills.Any(s => s == "C++")
                     select emp;
          //  q1.PrintEmployees();

            var q2 = from emp in emps
                     where emp.Skills.All(s => s.Length >=3)
                     select emp;
            q2.PrintEmployees();
        }
        private static void RunContains()
        {
            //can be instance method or Extension method
            // O(n) for list
            // O(n) hashset
            Console.WriteLine();
            Console.WriteLine("++++++++++");
            Console.WriteLine("RunContains()");
            Console.WriteLine("++++++++++");
            Console.WriteLine();
            var emps = Repository.LoadEmployees();
            var res1 = emps.Any(x => x.FirstName.Contains("Jo"));
            Console.WriteLine(res1);
            var e = new Employee { FirstName = "John" };
            var result2 = emps.Contains(e);//false bec reference type not value must equality
            Console.WriteLine(result2);

        }
    }
}
