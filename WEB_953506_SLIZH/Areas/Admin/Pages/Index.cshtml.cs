using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB_953506_SLIZH.Data;
using WEB_953506_SLIZH.Entities;

namespace WEB_953506_SLIZH.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WEB_953506_SLIZH.Data.ApplicationDbContext _context;

        public IndexModel(WEB_953506_SLIZH.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; }

        public async Task OnGetAsync()
        {
            Player = await _context.Players
                .Include(p => p.DisciplineName).ToListAsync();
        }
    }
}
