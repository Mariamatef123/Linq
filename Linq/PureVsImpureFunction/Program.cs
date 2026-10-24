namespace PureVsImpureFunction
{
    internal class Program
    {
        static List<int> numbers = new List<int> { 1, 2, 3, 4, 5,6 , 7, 8, 9 };
        static void Main(string[] args)
        {
           Print(numbers);
           AddInteger1(10);
           var x = 3;
           AddInteger2(ref x);
           AddInteger3();
           var newList = AddInteger4(numbers, 11);
           Print(numbers);
           Print(newList);
        }
        static void Print (List<int> source)
        {
            foreach (var number in source)
            {
                Console.WriteLine($" {number} ");
            }
            Console.WriteLine();  
        }
        static void AddInteger1(int num)
        {
            numbers.Add(num);
        }
        static void AddInteger2(ref int num) {
            num++;
            numbers.Add(num);
        }
        static void AddInteger3()
        {
            numbers.Add(new Random().Next());
        }
        static List<int> AddInteger4(List<int> numbers, int num)
        {
            var result = new List<int>(numbers);
            result.Add(num);
            return result;  
        }
    }
}
