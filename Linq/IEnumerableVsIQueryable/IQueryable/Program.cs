using Data;

namespace IQueryable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new BookContext();
            IQueryable<Book> books = db.Books;
            var boooksOver50 = books.Where(b =>  b.Price > 50.00M);
            foreach (var book in boooksOver50)
            {
                Console.WriteLine(book);
            }
        }
    }
}
