using System;

namespace Wave.Api.TaskEndpoints
{
    public class UserListRequest
    {
        public int Page { get; set; }
        public int PerPage { get; set; }
    }
}
