using System.Threading.Tasks;
using Abp.Application.Services;
using Moises2024.Authorization.Accounts.Dto;

namespace Moises2024.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
