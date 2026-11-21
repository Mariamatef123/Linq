using Shared;

namespace Skip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();
            var q1 = emps.Skip(2);//skip first 2 elements
            //q1.PrintEmployees();

            var q2 = emps.SkipWhile(x=> x.Salary != 50000);// skip while salary doesnt  = 50000
           //q2.PrintEmployees();

            var q3 = emps.SkipLast(2);
            q3.PrintEmployees();//skip last 2 elements


        }
    }
}
