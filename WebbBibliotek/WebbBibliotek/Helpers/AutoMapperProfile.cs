using AutoMapper;
using WebbBibliotek.Entities;
using WebbBibliotek.Models.Users;

namespace WebbBibliotek.Helpers
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
