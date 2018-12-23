using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TomsAbp.Configuration.Dto;

namespace TomsAbp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TomsAbpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
