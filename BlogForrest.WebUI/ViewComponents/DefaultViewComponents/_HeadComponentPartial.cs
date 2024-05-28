using Microsoft.AspNetCore.Mvc;

namespace BlogForrest.WebUI.ViewComponents.DefaultViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
