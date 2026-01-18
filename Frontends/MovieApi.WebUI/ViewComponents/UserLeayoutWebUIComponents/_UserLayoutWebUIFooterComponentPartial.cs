using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.UserLeayoutWebUIComponents
{
    public class _UserLayoutWebUIFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
