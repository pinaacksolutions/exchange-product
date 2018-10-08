using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SampleBarterApp.Configuration.Dto;

namespace SampleBarterApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SampleBarterAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
