using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Moises2024.MultiTenancy.Dto;

namespace Moises2024.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
