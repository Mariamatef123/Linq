using Shared;

namespace Take
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();
            var q1 = emps.Take(2);//take first 2 elements
           // q1.PrintEmployees();

            var q2 = emps.TakeWhile(x => x.Salary != 50000);// take while salary doesnt  = 50000
            //q2.PrintEmployees();

            var q3 = emps.TakeLast(2);
           q3.PrintEmployees();//take last 2 elements


        }
    }
}
