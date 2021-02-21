using System;
using System.Collections.Generic;
using Wave.Api.ApplicationCore;

namespace Wave.Api.Infrastructure.Data
{
    public static class SeedData
    {
        public static List<User> Users()
        {
            int id = 1;

            var users = new List<User>()
            {
                new User 
                {
                    Id = id++,
                    Login = "user" + id,
                    Password = "12345678",
                    FirstName = "James",
                    LastName = "Smith",
                },
                new User
                {
                    Id = id++,
                    Login = "user" + id,
                    Password = "12345678",
                    FirstName = "John",
                    LastName = "Johnson",
                },
                new User
                {
                    Id = id++,
                    Login = "user" + id,
                    Password = "12345678",
                    FirstName = "Robert",
                    LastName = "Williams",
                },
                new User
                {
                    Id = id++,
                    Login = "user" + id,
                    Password = "12345678",
                    FirstName = "Michael",
                    LastName = "Brown",
                },
                new User
                {
                    Id = id++,
                    Login = "user" + id,
                    Password = "12345678",
                    FirstName = "William",
                    LastName = "Jones",
                },
                new User
                {
                    Id = id++,
                    Login = "user" + id,
                    Password = "12345678",
                    FirstName = "David",
                    LastName = "Garcia",
                },
                new User
                {
                    Id = id++,
                    Login = "user" + id,
                    Password = "12345678",
                    FirstName = "Richard",
                    LastName = "Miller",
                },
                new User
                {
                    Id = id++,
                    Login = "user" + id,
                    Password = "12345678",
                    FirstName = "Joseph",
                    LastName = "Davis",
                },
                new User
                {
                    Id = id++,
                    Login = "user" + id,
                    Password = "12345678",
                    FirstName = "Thomas",
                    LastName = "Rodriguez",
                },
                new User
                {
                    Id = id++,
                    Login = "user" + id,
                    Password = "12345678",
                    FirstName = "Charles",
                    LastName = "Martinez",
                },
                new User
                {
                    Id = id++,
                    Login = "user" + id,
                    Password = "12345678",
                    FirstName = "Patricia",
                    LastName = "Lopez",
                },
                new User
                {
                    Id = id++,
                    Login = "user" + id,
                    Password = "12345678",
                    FirstName = "Jennifer",
                    LastName = "Gonzales",
                },
            };

            return users;
        }

        public static List<TaskItem> Tasks() 
        {
            int id = 1;

            var tasks = new List<TaskItem>()
            {
                new TaskItem() 
                { 
                    Id = id++,
                    OwnerId = 1,
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now,
                    Title = "Go to shop",
                    Type = "task",
                    Status = "new"
                }
            };

            return tasks;
        }
    }
}
