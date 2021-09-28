using Microsoft.AspNetCore.Mvc;

namespace WEB_953506_SLIZH.Views.Shared.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
