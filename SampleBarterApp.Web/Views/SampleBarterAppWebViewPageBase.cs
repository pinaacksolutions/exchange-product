using Abp.Web.Mvc.Views;

namespace SampleBarterApp.Web.Views
{
    public abstract class SampleBarterAppWebViewPageBase : SampleBarterAppWebViewPageBase<dynamic>
    {

    }

    public abstract class SampleBarterAppWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SampleBarterAppWebViewPageBase()
        {
            LocalizationSourceName = SampleBarterAppConsts.LocalizationSourceName;
        }
    }
}