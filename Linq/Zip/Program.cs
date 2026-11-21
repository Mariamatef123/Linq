using Shared;

namespace Zip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample2();
        }

        private static void RunExample1()
        {
            string[] colorName = { "Red", "Green", "Blue" };
            string[] colorCode = { "#FF0000", "#00FF00", "#0000FF" };

            var colorNameAndCode = colorName.Zip(colorCode, (name, code) => $"{name} {code}");//Zip method combines two sequences into one sequence by applying a specified function to the corresponding elements of both sequences. (until the lower cont elements)
            foreach (var item in colorNameAndCode)
            {
                Console.WriteLine(item);
            }
        }
        private static void RunExample2() { 
        var employees = Repository.LoadEmployees().ToArray();
          var firstThreeEmployees = employees[..3];
            var lastThreeEmployees = employees[^3..];   
          var teams = firstThreeEmployees.Zip(lastThreeEmployees, (first, last) => $"{first.FirstName} with {last.FirstName}");
           var  teams2 = from team in  firstThreeEmployees.Zip(lastThreeEmployees)
                         select $"{team.First.FirstName} with {team.Second.FirstName}";
            foreach (var team in teams2)
            {
                Console.WriteLine(team);
            }
        }
    }
}
