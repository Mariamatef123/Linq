using Shared;

namespace Grouping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunToLookup();
        }

        private static void RunGroupBy()
        {
            //deferred exec 
            //each iterate => group again
            //IEnumerable<IGrouping<TKey,TSource>>
            var emps = Repository.LoadEmployees();

            var groups = emps.GroupBy(x => x.Department);
        foreach(var group in groups)
            {
                var key = group.Key;
                Console.WriteLine(key);
                group.PrintEmployees();
            }
        }
        private static void RunGroupByQuerySyntax()
        {
            //deferred exec
            var emps = Repository.LoadEmployees();

            var groups = from emp in emps
                         group emp by emp.Department;
            foreach (var group in groups)
            {
                var key = group.Key;
                Console.WriteLine(key);
                group.PrintEmployees();
            }
        }
        private static void RunToLookup()
        {
            //immendiate exec 
            //buffer the result in memory (multiple process)
            //ILookup<TKey,TSource>
            var emps = Repository.LoadEmployees();

            var groups = emps.ToLookup(x => x.Department);
            foreach (var group in groups)
            {
                var key = group.Key;
                Console.WriteLine(key);
                group.PrintEmployees();
            }
        }
    }
}
