using System;

namespace Wave.Api.ApplicationCore
{
    public class TaskItem : BaseEntity
    { 
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Title { get; set; }
    }
}
