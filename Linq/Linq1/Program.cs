using Shared;

namespace Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var employees = Repository.LoadEmployees();
            var femaleWithFNameStartingWithM01 = employees
                .Filter(e => e.Gender == "Female" && e.FirstName.StartsWith("M"));
            femaleWithFNameStartingWithM01.PrintEmployees();
            var femaleWithFNameStartingWithM02 = employees
            .Where(e => e.Gender == "Female" && e.FirstName.StartsWith("M"));
            femaleWithFNameStartingWithM02.PrintEmployees();
        }
    }
}
