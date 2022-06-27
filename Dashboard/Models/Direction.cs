using System;
using System.Collections.Generic;

#nullable disable

namespace Dashboard.Models
{
    public partial class Direction
    {
        public Direction()
        {
            Milestones = new HashSet<Milestone>();
            Projects = new HashSet<Project>();
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public byte? Completion { get; set; }
        public byte? Priority { get; set; }

        public virtual ICollection<Milestone> Milestones { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
