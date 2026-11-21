
namespace OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Banana", "Apple", "Mango", "Orange", "Grapes" };
            var orderedFruits = fruits.OrderBy(f => f);//ASC
            var orderedFruits2 = from f in fruits
                                 orderby f  //can be orderby f ascending
                                 select f;
            foreach (var fruit in orderedFruits2)
            {
                Console.WriteLine(fruit);
            }
             var orderedFruitsDesc = fruits.OrderByDescending(f => f);//DESC
            var orderedFruitsDesc2 = from f in fruits
                                orderby f descending
                                select f;
            foreach (var fruit in orderedFruitsDesc)
            {
                Console.WriteLine(fruit);
            }

            var orderedFruitsByLength = fruits.OrderBy(f => f.Length);//ASC according to length of string
            var orderedFruitsByLength2 = from f in fruits
                                 orderby f.Length  
                                 select f;
            foreach (var item in orderedFruitsByLength)
            {
                Console.WriteLine(item);
            }
        }
    }
}
