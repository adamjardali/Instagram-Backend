using AutoMapper;
using Instagram.Dto;
using Instagram.Models;

namespace Instagram.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserDto>();
            CreateMap<User, UserDto>();
            CreateMap<Follower, FollowerDto>();
            CreateMap<FollowerDto, Follower>();
            CreateMap<UserCreateDto, User>();
            CreateMap<UserUpdateDto, User>();
        }
    }
}
