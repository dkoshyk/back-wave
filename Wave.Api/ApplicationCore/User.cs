using System;
using System.Collections.Generic;

namespace Wave.Api.ApplicationCore
{
    public class User : BaseEntity 
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] ImageStored { get; set; }
        public DateTime? LastActiveOn { get; set; }

        public ICollection<TaskItem> Tasks { get; set; }
    }
}
