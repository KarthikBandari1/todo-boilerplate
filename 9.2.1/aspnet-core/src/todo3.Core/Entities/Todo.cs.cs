using Abp.Domain.Entities;
using System;

namespace todo3.Entities
{
    public class Todo : Entity<int>
    {
        public string Title { get; set; }
        public string Assignee { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
