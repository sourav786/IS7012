﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Core_Crud.Models;

namespace Core_Crud.Pages.Destinations
{
    public class CreateModel : PageModel
    {
        private readonly Core_Crud.Models.Core_Crud0921Context _context;

        public CreateModel(Core_Crud.Models.Core_Crud0921Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CountryId"] = new SelectList(_context.Country, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Destination Destination { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Destination.Add(Destination);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}