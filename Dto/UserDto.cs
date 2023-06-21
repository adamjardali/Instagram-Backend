using System;

namespace Instagram.Dto
{
	public class UserDto
	{
		public Guid Id {get;set;}
		public string UserName {get;set;}
		public DateTimeOffset CreatedAt { get;set;}

	}

	public class UserCreateDto
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Bio { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePicture { get; set; } 	
    }

    public class UserUpdateDto
	{
		public Guid Id{get;set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Bio { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePicture { get; set; } 	
    } 
}