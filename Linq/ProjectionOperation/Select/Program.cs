using Shared;

namespace Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample03();
        }

        private static void RunExample01()
        {
            List<string> words = new List<string> { "one", "two", "three", "four", "five" };
            var result = words.Select(w => w.ToUpper());
            var result2 = from w in words
                          select w.ToUpper();
            foreach (var length in result)
            {
                Console.WriteLine(length);
            }
        }
   
        private static void RunExample02()
        {
            List<int> numbers = new() { 2, 3, 5, 7 };
            var result = numbers.Select(w => w*w);
            var result2 = from w in numbers
                          select w*w;
            foreach (var length in result)
            {
                Console.WriteLine(length);
            }
        }
        private static void RunExample03()
        {
            var employees = Repository.LoadEmployees();
            var result = employees.Select(x =>
            {
                return new EmployeeDto
                {
                    Name = $"{x.FirstName} {x.LastName}",
                    TotalSkills = x.Skills.Count()
                };
            });
            foreach (var length in result)
            {
                Console.WriteLine(length);
            }
        }
    }
}
