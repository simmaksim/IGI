using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WEB_953506_SLIZH.Models;

namespace WEB_953506_SLIZH.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private List<MenuItem> menuItems = new List<MenuItem>
        {
            new MenuItem{ Controller="Home", Action="Index", Text="Lab 2"},
            new MenuItem{ Controller="product", Action="Index", Text="Каталог"},
            new MenuItem{ IsPage=true, Area="Admin", Page="/Index", Text="Администрирование"}
        };

        public IViewComponentResult Invoke()
        {
            var controller = ViewContext.RouteData.Values["controller"];
            var page = ViewContext.RouteData.Values["page"];
            var area = ViewContext.RouteData.Values["area"];

            foreach (var item in menuItems)
            {
                if ((controller?.Equals(item.Controller) ?? false) || (area?.Equals(item.Area) ?? false))
                {
                    item.Active = "active";
                }
            }
            return View(menuItems);
        }
    }
}
