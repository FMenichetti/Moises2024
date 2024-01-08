using System.Threading.Tasks;
using Abp.Application.Services;
using Moises2024.Sessions.Dto;

namespace Moises2024.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
