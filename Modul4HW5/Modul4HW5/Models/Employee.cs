using System;
using System.Collections.Generic;

namespace Modul4HW5.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HiredData { get; set; }

        public DateTime? DataOfBirth { get; set; }

        public int OfficeId { get; set; }
        public Office Office { get; set; }

        public int TitleId { get; set; }
        public Title Title { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
