using System;
using System.Collections.Generic;

namespace Modul4HW5.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime? DataOfBirth { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
