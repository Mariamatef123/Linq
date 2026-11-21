namespace Linq3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var evenNumbersUsingExtensionWhere = 
                numbers.Where(n => n % 2 == 0);

            var evenNumbersUsingEnumerableWhere = 
                Enumerable.Where(numbers, n => n % 2 == 0);
            var evenNumbersUsingQuerySyntax = 
                from n in numbers
                where n % 2 == 0
                select n;
        }
    }
}
