using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public static class ExtensionFunctional01
    {
        public static IEnumerable<Employee> Filter(IEnumerable<Employee> source,Func<Employee,bool> predicate)
        {

            foreach (var employee in source)
            {
                if (predicate(employee))
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
