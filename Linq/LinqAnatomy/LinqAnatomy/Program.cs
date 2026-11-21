using System.Threading.Channels;

namespace LinqAnatomy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoExecutionOrder();
        }

        private static void DemoFluentAPI()
        {
            // method chaining and extension method to make statement look like a sentence
            // is code that reads as a sentence
            var deck = new Deck();
            var cards = deck.Shuffle();
            var query = cards
                .OrderBy(x => x.Value).Skip(10).Take(10)
                .OrderBy(x => x.Suite).ToList();
            foreach(var item in query)
                Console.WriteLine(item.Name);
        }
        private static void DemoIEnumerableIQueryable()
        {
            var deck = new Deck();

            //LINQ to objects
            //which mostly just does literally what it is told
            //if you sort then pages ,then it sorts then pages
            //if you page then sort then it pages then sorts
            var queryIEnumerable = deck.Shuffle()
                .Where(x => x.Value > 5).Skip(5).OrderBy(x => x.Value)
                .ThenByDescending(x => x.Suite).Take(5).AsEnumerable();

            //Linq to Sql
            //query is being composed expression tree
            //when execute provider inspect your query tree
            var queryIQueryable = deck.Shuffle()
                .Where(x => x.Value > 5).Skip(5).OrderBy(x => x.Value)
                .ThenByDescending(x => x.Suite).Take(5).AsQueryable();

        }
        private static void DemoExecutionOrder()
        {
            //left to right (all expression in C# are exec from left to right)
            // understanding the semantics of query exec , can lead to some meaningful optimization
            //where is not required to find all mating items before fetching the first matching
            //where fetches mating item on demand
            //IENumerable / foreach/yield element ar not returned at once /one at time
            var numbers = new int[] { 8, 2, 3, 5, 6, 2, 5, 2 };
            var query = numbers
     .Where(x =>
     {
         Console.WriteLine($"Where({x} > 5) => {x > 5}");
         return x > 5;
     })
     .Select(x =>
     {
         Console.WriteLine($"\tSelect({x} X {x}) => {x * x}");
         return x * x;
     })
     .Where(x =>
     {
         var result = x % 6 == 0;
         Console.WriteLine($"\t\tWhere({x} % 6) == 0 => {result}");
         if (result)
             Console.WriteLine($"\t\t\t\tTake: {x}");

         return x % 6 == 0;
     })
     .Take(2);
            var list = query.ToList();
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        
        }
        private static void DemoImmediateExecution()
        {
            // Immediate: the data source is read and the operation is performed
            //            at the point in the code where the query is declared.

            // not up to date
            // not expensive to call
            // list are big

            var numbers = new int[] { 8, 2, 3, 4, 1, 6, 5, 7, 9 };
            var list = numbers
                .Where(x => x > 5)          // 8, 6, 7, 9
                .Take(2)                    // 8, 6
                .ToList();

            foreach (var n in list)
                Console.WriteLine(n);
        }
        private static void DemoDeferredExecution()
        {
            // Not executed when constructed, only when it's enumerated
            // Setting up a data structure that describes the query

            // queries are always up-to-date.
            // queries is more expensive that list to retrieve result
            // queries are tiny
            var numbers = new int[] { 8, 2, 3, 4, 1, 6, 5, 7, 9 };
            var query = numbers
                .Where(x => x > 5)          // 8, 6, 7, 9
                .Select(x => x * x)
                .Take(2);                   // 64, 36

            foreach (var n in query)
                Console.WriteLine(n);
        }
        private static void DemoDeferredStreamedExecution()
        {
            // Deferred Execution(Streaming) :
            // at the time of execution they do not read all source data
            // before the yield element
            // Where is not required to find all matching items before fetching the first matching item
            // Where fetches matching items "on demand"
            var numbers = new int[] { 8, 2, 3, 4, 1, 6, 5, 7, 9 };

            var query = numbers
                .Where(x =>
                {
                    Console.WriteLine($"Where({x} > 5) => {x > 5}");
                    return x > 5;
                })
                .Select(x =>
                {
                    Console.WriteLine($"\tSelect({x} X {x}) => {x * x}");
                    return x * x;
                })
                .Where(x =>
                {
                    var result = x % 6 == 0;
                    Console.WriteLine($"\t\tWhere({x} % 6) == 0 => {result}");
                    if (result)
                        Console.WriteLine($"\t\t\t\tTake: {x}");

                    return x % 6 == 0;
                })
                .Take(2);

            var list = query.ToList();
        }
        private static void DemoDeferredNonStreamedExecution()
        {
            // Deferred (Non Streaming): i.e. Sorting, grouping must read all source data before yield
            // Does not mean "this is a sequence that is ordered"
            // This is a sequence that has had an ordering operation applied to it
            // ThenBy to impose additional ordering

            var numbers = new int[] { 8, 2, 3, 4, 1, 6, 5, 7, 9 };
            var query = numbers
                .Where(x =>
                {
                    Console.WriteLine($"Where({x} > 5) => {x > 5}");
                    return x > 5;
                })
                .OrderBy(x => x) // Buffering: // 6, 7, 8, 9
                .Select(x =>
                {
                    var result = x * x;
                    Console.WriteLine($"\tSelect({x} X {x}) => {result}");
                    Console.WriteLine($"\t\t\t\tTake: {result}");
                    return result;
                })
                .Take(2); // 36, 49
        }
        private static void DemoTake()
        {
            // Take clause just appends a Take operation to the query;
            // it does not execute the query
            // You must put the Take operation where it needs to be. Remember,
            // x.Take(y).Where(z) and x.Where(z).Take(y) are very different queries.
            // changing the take location change the meaning of the query
            // put it in the right place as early as possible,
            // but not so early that it changes the meaning of the query

            var deck = new Deck();

            var cards = deck.GetSample();

            var query = cards         // { Jack Clubs, 9 Diamonds, 4 Hearts, 10 Spades, 3 Hearts, 6 Hearts }
                .Where(x => x.IsRed)  // {              9 Diamonds, 4 Hearts,             3 Hearts, 6 Hearts }
                .Skip(3)              // {                                                6 Hearts }
                .Take(3);             // {                                                6 Hearts }

            var list = query.ToList(); // { 6 Hearts }

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
        private static void DemoFilterOrder()
        {
            // Filter / Order (Top 10 in the Red Cards)
            var deck = new Deck();

            var cards = deck.Shuffle();

            var query1 = cards
                .Where(x => x.IsRed)
                .OrderBy(x => x.Value)
                .Take(10);

            foreach (var q in query1)
            {
                Console.WriteLine(q);
            }

            // Order / Filter (red cards in the top 10)
            var query2 = cards
                .OrderBy(x => x.Value)
                .Take(10)
                .Where(x => x.IsRed);

          foreach(var q in query2)
            {
                Console.WriteLine(q);
            }
        }

    }
}
