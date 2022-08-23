

using Chat.Application.Dtos;
using Chat.Domain.Entities;

namespace Chat.Application.Profile
{
    public class UserProfile: AutoMapper.Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}
