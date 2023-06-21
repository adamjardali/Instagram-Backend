using System;

namespace Instagram.Models
{
    public class Follower
    {
    	public Guid Id { get; init; }
        public Guid FollowerId { get; init; }
        public Guid FollowingId { get; init; }
		public DateTimeOffset CreatedAt { get; init; }
    	public DateTimeOffset UpdatedAt { get; set; }
}
}
