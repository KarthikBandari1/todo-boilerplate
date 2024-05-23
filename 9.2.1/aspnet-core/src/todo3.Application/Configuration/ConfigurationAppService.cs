using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using todo3.Configuration.Dto;

namespace todo3.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : todo3AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
