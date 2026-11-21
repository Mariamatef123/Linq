using System;
using System.Collections.Generic;
using System.Text;

namespace SharedForSetsOperations
{
    public static class Repository
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee { EmployeeId = "E001", Name = "Alice" },
                new Employee { EmployeeId = "E002", Name = "Bob" },
                new Employee { EmployeeId = "E003", Name = "Charlie" }
            };
        }
        public static List<Meeting> GetMeetings()
        {
            return new List<Meeting>
            {
                new Meeting
                {
                    Title = "Project Kickoff",
                    Date = new DateOnly(2024, 6, 1),
                    StartTime = new TimeOnly(9, 0),
                    EndTime = new TimeOnly(10, 0),
                    Participants = new List<Employee>
                    {
                        new Employee { EmployeeId = "E001", Name = "Alice" },
                        new Employee { EmployeeId = "E002", Name = "Bob" }
                    }
                },
                new Meeting
                {
                    Title = "Design Review",
                    Date = new DateOnly(2024, 6, 2),
                    StartTime = new TimeOnly(14, 0),
                    EndTime = new TimeOnly(15, 0),
                    Participants = new List<Employee>
                    {
                        new Employee { EmployeeId = "E002", Name = "Bob" },
                        new Employee { EmployeeId = "E003", Name = "Charlie" }
                    }
                }
            };
        }
    }
}
