﻿using SupportDesk.Model;

namespace SupportDesk.Controllers
{
    public class UserRepository
    {
        public static List<User> Users { get; set; } = new List<User>(){
                new User
                {
                    UserId = 1,
                    EmpId = 066576,
                    Admin = false,
                    Name = "Demo User",
                    Phone = "01700000001",
                    Email = "rakibul.it@hameemgroup.com",
                    Password = "12345678",
    },
                new User
                {
                    UserId = 2,
                    EmpId = 066578,
                    Admin = false,
                    Name = "Demo User",
                    Phone = "01700000001",
                    Email = "demouser01@hameemgroup.com",
                    Password = "12345678",
                },
        };
    }
}