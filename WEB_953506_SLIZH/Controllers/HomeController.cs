using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_953506_SLIZH.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Text"] = "Лабораторная работа 2";
            ViewData["Lst"] = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(_listDemo, "ListItemValue", "ListItemText");
            return View();
        }

        private List<ListDemo> _listDemo;
        public HomeController()
        {
            _listDemo = new List<ListDemo>
            {
                new ListDemo{ ListItemValue = 1, ListItemText = "Item 1"},
                new ListDemo{ ListItemValue = 2, ListItemText = "Item 2"},
                new ListDemo{ ListItemValue = 3, ListItemText = "Item 3"}

            };
        }
    }
    public class ListDemo
    {
        public int ListItemValue { get; set; }
        public string ListItemText { get; set; }
    }
}
