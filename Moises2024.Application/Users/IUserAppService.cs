using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Moises2024.Roles.Dto;
using Moises2024.Users.Dto;

namespace Moises2024.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}