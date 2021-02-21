using System;

namespace Wave.Api.TaskEndpoints
{
    public class CreateTaskResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime? DeadlineOn { get; set; }
    }
}
