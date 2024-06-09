using Microsoft.AspNetCore.Mvc;

namespace BlogForrest.WebUI.ViewComponents.DefaultViewComponents
{
    public class _NavBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}
