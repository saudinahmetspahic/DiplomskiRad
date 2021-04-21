﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.EntityModels
{
    public enum UserRole { User, Admin }
    public class UserAccount
    {
        public int Id { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
    }
}
