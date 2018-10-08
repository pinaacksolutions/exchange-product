using System.Threading.Tasks;
using Abp.Application.Services;
using SampleBarterApp.Configuration.Dto;

namespace SampleBarterApp.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}