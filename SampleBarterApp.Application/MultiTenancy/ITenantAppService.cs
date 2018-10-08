using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SampleBarterApp.MultiTenancy.Dto;

namespace SampleBarterApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
