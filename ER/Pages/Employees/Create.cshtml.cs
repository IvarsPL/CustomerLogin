﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ER.Data;
using ER.Models;

namespace ER.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly ER.Data.ERContext _context;

        public CreateModel(ER.Data.ERContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Specialists Specialists { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Specialists.Add(Specialists);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
