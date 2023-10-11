using Microsoft.AspNetCore.Mvc;

namespace Bistros.Presentation.Web.ViewComponents
{
    public class _SpecialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
