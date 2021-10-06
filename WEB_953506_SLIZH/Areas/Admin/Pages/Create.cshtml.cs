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
using WEB_953506_SLIZH.Data;
using WEB_953506_SLIZH.Entities;

namespace WEB_953506_SLIZH.Areas.Admin.Pages
{
    public class CreateModel : PageModel
    {
        private readonly WEB_953506_SLIZH.Data.ApplicationDbContext _context;
        private readonly IWebHostEnvironment _enviroment;
        public CreateModel(WEB_953506_SLIZH.Data.ApplicationDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _enviroment = env;
        }

        public IActionResult OnGet()
        {
        ViewData["DisciplineId"] = new SelectList(_context.Disciplines, "DisciplineId", "DisciplineName");
            return Page();
        }

        [BindProperty]
        public Player Player { get; set; }
        [BindProperty]
        public IFormFile Image { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Players.Add(Player);
            await _context.SaveChangesAsync();
            if (Image!=null)
            {
                var fileName = $"{Player.PlayerId}" + Path.GetExtension(Image.FileName);
                var path = Path.Combine(_enviroment.WebRootPath, "Images", fileName);
                using (var fStream = new FileStream(path, FileMode.Create))
                {
                    await Image.CopyToAsync(fStream);
                }
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
