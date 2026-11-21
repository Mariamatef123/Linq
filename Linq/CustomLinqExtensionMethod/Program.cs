using Shared;

namespace CustomLinqExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var employees = Repository.LoadEmployees();
           // employees.PrintEmployees();
            //total 5 =>2 emps/page = 5/2 = 3 pages
            var pageNo = 2;
            var pagesize = 2;
            //var page1 = employees.Skip((pageNo - 1) * pagesize).Take(pagesize);
            //page1.PrintEmployees();
            //var page1 = employees.Paginate(null, 2);
            //page1.PrintEmployees();
            var pageCovered = employees.WhereWithPaginate(x => x.HasHealthInsurance, 1, 2);
            pageCovered.PrintEmployees();
            
        }
    }
}
