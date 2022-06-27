using System;
using System.Collections.Generic;

#nullable disable

namespace Dashboard.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int? Position { get; set; }
        public byte[] Photo { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
