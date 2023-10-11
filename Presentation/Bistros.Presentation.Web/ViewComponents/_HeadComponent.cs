using Microsoft.AspNetCore.Mvc;

namespace Bistros.Presentation.Web.ViewComponents
{
    public class _HeadComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
