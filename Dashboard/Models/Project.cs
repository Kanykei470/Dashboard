using System;
using System.Collections.Generic;

#nullable disable

namespace Dashboard.Models
{
    public partial class Project
    {
        public Project()
        {
            Milestones = new HashSet<Milestone>();
            Tasks = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Direction { get; set; }
        public byte? Completion { get; set; }
        public byte? Priority { get; set; }

        public virtual Direction DirectionNavigation { get; set; }
        public virtual ICollection<Milestone> Milestones { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
