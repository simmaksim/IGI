using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WEB_953506_SLIZH.Data;
using WEB_953506_SLIZH.Entities;

namespace WEB_953506_SLIZH.Areas.Admin.Pages
{
    public class EditModel : PageModel
    {
        private readonly WEB_953506_SLIZH.Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment _enviroment; 
        public EditModel(WEB_953506_SLIZH.Data.ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _enviroment = env;
        }

        [BindProperty]
        public Player Player { get; set; }
        [BindProperty]
        public IFormFile Image { get; set; }
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
           ViewData["DisciplineId"] = new SelectList(_context.Disciplines, "DisciplineId", "DisciplineName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Image != null)
            {
                var fileName = $"{Player.PlayerId}" + Path.GetExtension(Image.FileName);
                Player.Photo = fileName;
                var path = Path.Combine(_enviroment.WebRootPath, "Images", fileName);
                using (var fStream = new FileStream(path, FileMode.Create))
                {
                    await Image.CopyToAsync(fStream);
                }
            }
            _context.Attach(Player).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerExists(Player.PlayerId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PlayerExists(int id)
        {
            return _context.Players.Any(e => e.PlayerId == id);
        }
    }
}
