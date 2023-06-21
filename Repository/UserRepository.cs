using System;

﻿using Instagram.Data;
using Instagram.Dto;
using Instagram.Interfaces;
using Instagram.Models;

namespace Instagram.Repository
{
	public class UserRepository : IUserRepository
	{
		private readonly DataContext _context;

		public UserRepository(DataContext context)
		{
			_context = context;
		}

		public User GetUser(Guid Id)
		{
			return _context.Users.Where(p => p.Id == Id).FirstOrDefault();
		}

		public User GetUser(string UserName)
		{
			return _context.Users.Where(p => p.UserName == UserName).FirstOrDefault();
		}

		public ICollection<User> GetUsers()
		{
			return _context.Users.OrderBy(p => p.Id).ToList();
		}

		public bool UserExists(Guid Id)
		{
			return _context.Users.Any(p => p.Id == Id);
		}

		public bool UserExists(String UserName)
		{
			return _context.Users.Any(p => p.UserName == UserName);
		}

		public bool Save()
		{
			var saved = _context.SaveChanges();
			return saved > 0 ? true : false;
		}

		public bool CreateUser(User user)
		{
			_context.Add(user);
			return Save();
		}

		public bool DeleteUser(User user)
		{
			_context.Remove(user);
			return Save();
		}

		public bool UpdateUser(User user)
		{
			_context.Update(user);
			return Save();
		}






	}
}