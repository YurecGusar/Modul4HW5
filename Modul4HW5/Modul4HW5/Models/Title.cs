using System;
using System.Collections.Generic;

namespace Modul4HW5.Models
{
    public class Title
    {
        public int TitleId { get; set; }
        public string Name { get; set; }
        public List<Employee> Employes { get; set; } = new List<Employee>();
    }
}
