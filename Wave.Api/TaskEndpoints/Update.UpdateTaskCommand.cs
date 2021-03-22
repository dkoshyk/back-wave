using System;
using System.ComponentModel.DataAnnotations;

namespace Wave.Api.TaskEndpoints
{
    public class UpdateTaskCommand
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }
        public DateTime? DeadlineOn { get; set; }
        public DateTime? ClosedOn { get; set; }
    }
}
