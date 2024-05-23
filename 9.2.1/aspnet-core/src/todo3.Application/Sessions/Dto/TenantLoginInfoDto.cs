using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using todo3.MultiTenancy;

namespace todo3.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
