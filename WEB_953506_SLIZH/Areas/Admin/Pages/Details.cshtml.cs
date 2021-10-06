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
    public class DetailsModel : PageModel
    {
        private readonly WEB_953506_SLIZH.Data.ApplicationDbContext _context;

        public DetailsModel(WEB_953506_SLIZH.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Player Player { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Player = await _context.Players
                .Include(p => p.DisciplineName).FirstOrDefaultAsync(m => m.PlayerId == id);

            if (Player == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
