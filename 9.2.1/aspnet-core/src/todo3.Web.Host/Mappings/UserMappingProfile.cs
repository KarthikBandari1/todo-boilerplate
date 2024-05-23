using AutoMapper;
using todo3.Authorization.Users;
using todo3.MultiTenancy.Dto;
using todo3.MultiTenancy;
using todo3.Sessions.Dto;
using todo3.Users.Dto;

namespace todo3.Mappings
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserLoginInfoDto>();
            CreateMap<UserLoginInfoDto, User>();
            CreateMap<User, UserDto>();
            CreateMap<UserDto,User > ();
            CreateMap<Tenant, TenantDto>();
            CreateMap<TenantDto,Tenant > ();
            CreateMap<User, CreateUserDto>();
            CreateMap<CreateUserDto, User>();




        }
    }
}
