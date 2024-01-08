using Abp.Web.Mvc.Views;

namespace Moises2024.Web.Views
{
    public abstract class Moises2024WebViewPageBase : Moises2024WebViewPageBase<dynamic>
    {

    }

    public abstract class Moises2024WebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected Moises2024WebViewPageBase()
        {
            LocalizationSourceName = Moises2024Consts.LocalizationSourceName;
        }
    }
}