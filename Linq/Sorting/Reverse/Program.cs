namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Elderberry" , "Apple", "Cherry", "Banana","Date"};
            var reversedFruits = fruits.Reverse();//must store in variable
            foreach (var fruit in reversedFruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
