using System;
using System.Collections.Generic;
using Instagram.Dto;
using Instagram.Models;

namespace Instagram.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
        User GetUser(Guid Id);
        bool UserExists(Guid Id);
        bool UserExists(string UserName);
        User GetUser(string UserName);
        bool CreateUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(User user);
        bool Save();
    }
}
