using System;

namespace Wave.Api.TaskEndpoints
{
    public class TaskListRequest
    {
        public int Page { get; set; }
        public int PerPage { get; set; }
        public string ContainsTitle { get; set; }
        public string EqualType { get; set; }
        public string EqualStatus { get; set; }
        public int? EqualPriority { get; set; }
        public DateTime? FromDeadlineOn { get; set; }
        public DateTime? ToDeadlineOn { get; set; }
    }
}
