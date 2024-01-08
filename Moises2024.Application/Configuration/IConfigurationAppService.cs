using System.Threading.Tasks;
using Abp.Application.Services;
using Moises2024.Configuration.Dto;

namespace Moises2024.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}