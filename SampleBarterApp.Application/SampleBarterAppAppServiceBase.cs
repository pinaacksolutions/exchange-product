using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using SampleBarterApp.Authorization.Users;
using SampleBarterApp.MultiTenancy;
using SampleBarterApp.Users;
using Microsoft.AspNet.Identity;

namespace SampleBarterApp
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class SampleBarterAppAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected SampleBarterAppAppServiceBase()
        {
            LocalizationSourceName = SampleBarterAppConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}