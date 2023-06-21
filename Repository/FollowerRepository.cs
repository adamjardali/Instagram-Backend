using System;

﻿using Instagram.Data;
using Instagram.Dto;
using Instagram.Interfaces;
using Instagram.Models;

namespace Instagram.Repository
{
	public class FollowerRepository : IFollowerRepository
	{
		private readonly DataContext _context;

		public FollowerRepository(DataContext context)
		{
			_context = context;
		}

		public ICollection<Follower> GetFollowers(Guid Id)
		{
			return _context.Followers.Where(f => f.FollowingId == Id).Select(f => f.FollowerId).ToList();
		}

		





	}
}