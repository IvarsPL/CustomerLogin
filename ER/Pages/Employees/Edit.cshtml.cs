using ER.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ER.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly ER.Data.ERContext _context;

        public EditModel(ER.Data.ERContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Specialists).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecialistsExists(Specialists.Id))
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

        private bool SpecialistsExists(int id)
        {
            return _context.Specialists.Any(e => e.Id == id);
        }
    }
}
