using System.Collections;

namespace Linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var collection = new ArrayList { 1, true, DateTime.Now };
            // Using LINQ to filter even numbers
            IEnumerable<int> evenNumbers = numbers.Where(n => n % 2 == 0);//construction
            //  var evenNumbers2 = collection.Where(n => n % 2 == 0); error because ArrayList implements IEnumerable but not IEnumerable<T>
            numbers.Add(10);
            numbers.Add(12);
            numbers.Remove(4);

            //2, 6, 8, 10, 12
            foreach (var number in evenNumbers)//enumaration
                                               //lazy loading, the query is not executed until we enumerate over it
            {
                Console.Write($"{number}");
            }
        }
    }
}
