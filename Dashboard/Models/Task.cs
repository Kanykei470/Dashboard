using System;
using System.Collections.Generic;

#nullable disable

namespace Dashboard.Models
{
    public partial class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Milestone { get; set; }
        public int? Direction { get; set; }
        public int? Project { get; set; }
        public int? Employee { get; set; }
        public byte? Completion { get; set; }
        public byte? Priority { get; set; }
        public DateTime? DateOfBegining { get; set; }
        public DateTime? DateOfFinish { get; set; }

        public virtual Direction DirectionNavigation { get; set; }
        public virtual Employee EmployeeNavigation { get; set; }
        public virtual Milestone MilestoneNavigation { get; set; }
        public virtual Project ProjectNavigation { get; set; }
    }
}
