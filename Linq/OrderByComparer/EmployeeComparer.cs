using SharedForSorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByComparer
{
    internal class EmployeeComparer: IComparer<Employee>
    {
        // "2017-FI-1343" => "2017","FI","1343"
        public int Compare(Employee? x, Employee? y)
        {
            var e1Year = Convert.ToInt32(x?.EmployeeNo?.Split('-')[0]);
            var e2Year = Convert.ToInt32(y?.EmployeeNo?.Split('-')[0]);
            var e1Seq = Convert.ToInt32(x?.EmployeeNo?.Split('-')[2]);
            var e2Seq = Convert.ToInt32(y?.EmployeeNo?.Split('-')[2]);

            if (e1Year == e2Year)
            {
                return e1Seq.CompareTo(e2Seq);
            }
            return e1Year.CompareTo(e2Year);

        }
    }
}
