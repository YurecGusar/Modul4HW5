using System;
using System.Collections.Generic;

namespace Modul4HW5.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartedTime { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
