﻿using DatingApp.API.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User username, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
