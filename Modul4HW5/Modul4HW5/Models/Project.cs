using System;
using System.Collections.Generic;

namespace Modul4HW5.Models
{
    public class Project
    {
        public virtual int ProjectId { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Budget { get; set; }
        public virtual DateTime StartedTime { get; set; }
        public virtual int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public virtual List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
