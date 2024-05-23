using AutoMapper;
using todo3.Authorization.Roles;
using todo3.Roles.Dto;

public class RoleMappingProfile : Profile
{
    public RoleMappingProfile()
    {
        CreateMap<Role, RoleDto>();
        CreateMap<RoleDto,Role>();

    }
}
