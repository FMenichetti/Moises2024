using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Moises2024.Configuration.Dto;

namespace Moises2024.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Moises2024AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
