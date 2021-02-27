using System.Collections.Generic;

namespace Wave.Api.TaskEndpoints
{
    public class TaskListResult
    {
        public List<TaskItemDto> Items { get; set; } = new List<TaskItemDto>();
        public int Count { get; set; }
    }
}
