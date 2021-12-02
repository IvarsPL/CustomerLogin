using ER.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ER.Pages.Employees
{
    public class DeleteModel : PageModel
    {
        private readonly ER.Data.ERContext _context;

        public DeleteModel(ER.Data.ERContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Specialists = await _context.Specialists.FindAsync(id);

            if (Specialists != null)
            {
                _context.Specialists.Remove(Specialists);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
