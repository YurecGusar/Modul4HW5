using System.Collections.Generic;

namespace Modul4HW5.Models
{
    public class Office
    {
        public virtual int OfficeId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Location { get; set; }
        public virtual List<Employee> Employes { get; set; } = new List<Employee>();
    }
}
