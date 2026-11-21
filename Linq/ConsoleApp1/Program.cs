namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits =
            {
    "Banana",
    "Apple",
    "Mango"
};

            var reversedFruits = fruits.Reverse();
            foreach(var r in reversedFruits)
            {
                Console.WriteLine(r);
            }
        }
    }
}
