using AutoMapper;
using StarternWebApi.Entities;
using StarternWebApi.Models.Users;

namespace StarternWebApi.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}