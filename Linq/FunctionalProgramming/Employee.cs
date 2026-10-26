using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public bool HasHealthInsurance { get; set; }
        public bool HasPensionPlan { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return 
                string.Format($""+$"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, HireDate: {HireDate.ToShortDateString()}, Gender: {Gender}, Department: {Department}, HasHealthInsurance: {HasHealthInsurance}, HasPensionPlan: {HasPensionPlan}, Salary: {Salary:C}");
        }
    }
}
