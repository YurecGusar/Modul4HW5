using System;
using System.Collections.Generic;

namespace Modul4HW5.Models
{
    public class Title
    {
        public virtual int TitleId { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Employee> Employes { get; set; } = new List<Employee>();
    }
}
