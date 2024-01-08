using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Moises2024.Roles.Dto;

namespace Moises2024.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
