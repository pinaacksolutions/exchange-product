using Abp.AutoMapper;
using SampleBarterApp.Sessions.Dto;

namespace SampleBarterApp.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}