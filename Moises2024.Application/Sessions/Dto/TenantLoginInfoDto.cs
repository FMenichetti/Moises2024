using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Moises2024.MultiTenancy;

namespace Moises2024.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}