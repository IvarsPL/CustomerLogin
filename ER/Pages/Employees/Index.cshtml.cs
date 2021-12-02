using ER.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ER.Pages.Employees
{

    public class IndexModel : PageModel
    {
        private readonly ER.Data.ERContext _context;

        public IndexModel(ER.Data.ERContext context)
        {
            _context = context;
        }

        public IList<Specialists> Specialists { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList ProfessionList { get; set; } //genres
        [BindProperty(SupportsGet = true)]
        public string EmployeeProfession { get; set; } //movieGenre

        public async Task OnGetAsync()
        {
            IQueryable<string> profQueryable = from m in _context.Specialists
                                               orderby m.Profession
                                               select m.Profession;

            var employees = from m in _context.Specialists
                            select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                employees = employees.Where(s => s.Name.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(EmployeeProfession))
            {
                employees = employees.Where(x => x.Profession == EmployeeProfession);
            }

            ProfessionList = new SelectList(await profQueryable.Distinct().ToListAsync());

            Specialists = await employees.ToListAsync();
        }
    }
}
