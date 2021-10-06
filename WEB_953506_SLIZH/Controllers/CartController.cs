using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_953506_SLIZH.Data;
using WEB_953506_SLIZH.Extensions;
using WEB_953506_SLIZH.Models;


namespace WEB_953506_SLIZH.Controllers
{
    public class CartController : Controller
    {
        private Cart _cart;
        private ApplicationDbContext _context;
        private string cartKey = "cart";
        public CartController(ApplicationDbContext context, Cart cart)
        {
            _context = context;
            _cart = cart;
        }
        public IActionResult Index()
        {
            return View(_cart.Items.Values);
        }
        [Authorize]
        public IActionResult Add(int id, string returnUrl)
        {
            var item = _context.Players.Find(id);
            if (item!=null)
            {
                _cart.AddToCart(item);
            }
            return Redirect(returnUrl);
        }
        public IActionResult Delete(int id)
        {
            _cart.RemoveFromCart(id);
            return RedirectToAction("Index");
        }
    }
}
