using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedForSorting
{
    public class Employee
    {
        public string EmployeeNo { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public bool HasHealthInsurance { get; set; }
        public bool HasPensionPlan { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return
                string.Format($"" +$"Employee No:{EmployeeNo}, "+$"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, HireDate: {HireDate.ToShortDateString()}, Gender: {Gender}, Department: {Department}, HasHealthInsurance: {HasHealthInsurance}, HasPensionPlan: {HasPensionPlan}, Salary: {Salary:C}");
        }
    }
}
