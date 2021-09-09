using System.Collections.Generic;

namespace Modul4HW5.Models
{
    public class Office
    {
        public int OfficeId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public List<Employee> Employes { get; set; } = new List<Employee>();
    }
}
