using System;
using System.Collections.Generic;
using Instagram.Dto;
using Instagram.Models;

namespace Instagram.Interfaces
{
    public interface IFollowerRepository
    {
        ICollection<Follower> GetFollowers(Guid Id);
        // ICollection<User> GetFollowers(string UserName);
        // bool Follow(Guid Id1, Guid Id2);
        // bool Follow(string User1, string User2);
        // bool Unfollow(Guid Id1, Guid Id2);
        // bool Unfollow(string User1, string User2);
        // bool Save();
    }
}
