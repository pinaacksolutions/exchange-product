using System.Threading.Tasks;
using Abp.Application.Services;
using SampleBarterApp.Sessions.Dto;

namespace SampleBarterApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
