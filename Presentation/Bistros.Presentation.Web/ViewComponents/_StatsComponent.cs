using Microsoft.AspNetCore.Mvc;

namespace Bistros.Presentation.Web.ViewComponents
{
    public class _StatsComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
