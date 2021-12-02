using ER.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ER.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly ER.Data.ERContext _context;

        public DetailsModel(ER.Data.ERContext context)
        {
            _context = context;
        }

        public Specialists Specialists { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Specialists = await _context.Specialists.FirstOrDefaultAsync(m => m.Id == id);

            if (Specialists == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/Employees/Index");
        }
    }
}
