using Abp.AutoMapper;
using Moises2024.Sessions.Dto;

namespace Moises2024.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}