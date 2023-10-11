using Microsoft.AspNetCore.Mvc;

namespace Bistros.Presentation.Web.ViewComponents
{
    public class _DishesComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
