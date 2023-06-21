using System;

namespace Instagram.Models
{
    public class User
    {
        public Guid Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Bio { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePicture { get; set; }
		public DateTimeOffset CreatedAt { get; init; }
    	public DateTimeOffset UpdatedAt { get; set; }	    
    }
}
