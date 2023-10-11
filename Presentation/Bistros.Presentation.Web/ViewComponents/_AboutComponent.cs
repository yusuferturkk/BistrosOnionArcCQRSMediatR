using Microsoft.AspNetCore.Mvc;

namespace Bistros.Presentation.Web.ViewComponents
{
    public class _AboutComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
