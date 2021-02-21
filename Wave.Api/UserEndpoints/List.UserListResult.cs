﻿using System;

namespace Wave.Api.TaskEndpoints
{
    public class UserListResult
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] ImageStored { get; set; }
        public DateTime? LastActiveOn { get; set; }
    }
}
