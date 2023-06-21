using System;

namespace Instagram.Models
{
    public class FollowerDto
    {
    	public Guid Id { get; set; }
        public Guid FollowerId { get; set; }
        public Guid FollowingId { get; set; }
		public DateTimeOffset CreatedAt { get; set; }
    	public DateTimeOffset UpdatedAt { get; set; }
}
}
