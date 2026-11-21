using Data;

namespace IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new BookContext();
            IEnumerable<Book> books = db.Books;
            var boooksOver50 = books.Where(b => {
                Console.WriteLine($"Processing book: {b.Id}");
                return b.Price > 50.00M;
            });
            foreach (var book in boooksOver50)
            {
                Console.WriteLine(book);
            }
        }
    }
}
