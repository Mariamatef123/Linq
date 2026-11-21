using Shared;

namespace Pagination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var page = 1;
            var size = 2;
            Console.WriteLine("Enter page size:");
         
            if(int.TryParse(Console.ReadLine(), out int resultPerPage))
            {
                size = resultPerPage;
            }
            Console.WriteLine("Enter page number:");
            if (int.TryParse(Console.ReadLine(), out int pageNo))
            {
                page = pageNo;
            }
            var emps = Repository.LoadEmployees();
            var result = emps.Paginate(page, size);
            var resultCount = result.Count();
            var startRecord = ((page - 1) * size) + 1;
            var endRecord = resultCount < size ? startRecord + resultCount - 1 : size * (page - 1) + size;
            Console.WriteLine($"{startRecord} to {endRecord}");
            result.PrintEmployees();
        }
    }
}
