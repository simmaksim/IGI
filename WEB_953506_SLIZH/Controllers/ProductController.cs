using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_953506_SLIZH.Entities;
using WEB_953506_SLIZH.Extensions;
using WEB_953506_SLIZH.Models;
using WEB_953506_SLIZH.Data;

namespace WEB_953506_SLIZH.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext _context;

        int _pageSize;
        
        public ProductController(ApplicationDbContext context)
        {
            _pageSize = 3;
            _context = context;
        }

        [Route("Catalog")]
        [Route("Catalog/Page_{pageNo}")]
        public IActionResult Index(int? group,int pageNo=1)
        {
            //var playersFiltered = _context;
                //.Where(d => !group.HasValue || d.DisciplineId == group.Value);
            ViewData["Disps"] = _context.Disciplines;

            ViewData["CurrDisp"] = group ?? 0;
            var filteredPlayers = _context.Players.Where(d => !group.HasValue || d.DisciplineId == group.Value);
            var model = ListViewModel<Player>.GetModel(filteredPlayers, pageNo, _pageSize);

            return Request.IsAjaxRequest() ? PartialView("_listpartial", model) : View(model);
        }
        /*
        private void SetupData()
        {
            _disciplines = new List<Discipline>
            {
                new Discipline {DisciplineId=1, DisciplineName="Dota 2"},
                new Discipline {DisciplineId=2, DisciplineName="CS:GO"}
            };

            _players = new List<Player>
            {
                new Player {PlayerId = 1, NickName="S1mple", Team="Natus Vincere", Cost = 4450000, DisciplineId = 2, Photo="Simple.jpg"},
                new Player {PlayerId = 2, NickName="Zywoo", Team="Vitality", Cost = 3400000, DisciplineId = 2, Photo="Zywoo.jpg"},
                new Player {PlayerId = 3, NickName="Device", Team="Ninjas in Pyjamas", Cost = 2000000, DisciplineId = 2, Photo="device.jpg"},
                new Player {PlayerId = 4, NickName="Arteezy", Team="Evil Geniuses", Cost = 2500000, DisciplineId = 1, Photo="Arteezy.jpg"},
                new Player {PlayerId = 5, NickName="Sumail", Team="OG", Cost = 4000000, DisciplineId = 1, Photo="SumaiL.jpg"},
                new Player {PlayerId = 6, NickName="Miracle", Team="Nigma", Cost = 3450000, DisciplineId = 1, Photo="Miracle.jpg"},
            };
        }*/
    }
}
