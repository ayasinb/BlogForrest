using Microsoft.AspNetCore.Mvc;

namespace BlogForrest.WebUI.ViewComponents.DefaultViewComponents
{
    public class _TopBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
