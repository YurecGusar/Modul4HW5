using System;
using System.Collections.Generic;

namespace Modul4HW5.Models
{
    public class Client
    {
        public virtual int ClientId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string SecondName { get; set; }
        public virtual DateTime? DataOfBirth { get; set; }
        public virtual DateTime DateOfRegistration { get; set; }
        public virtual List<Project> Projects { get; set; } = new List<Project>();
    }
}
