﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core_Crud.Models;

namespace Core_Crud.Pages.Destinations
{
    public class EditModel : PageModel
    {
        private readonly Core_Crud.Models.Core_Crud0921Context _context;

        public EditModel(Core_Crud.Models.Core_Crud0921Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Destination Destination { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Destination = await _context.Destination
                .Include(d => d.Country).FirstOrDefaultAsync(m => m.ID == id);

            if (Destination == null)
            {
                return NotFound();
            }
           ViewData["CountryId"] = new SelectList(_context.Country, "ID", "ID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Destination).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinationExists(Destination.ID))
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

        private bool DestinationExists(int id)
        {
            return _context.Destination.Any(e => e.ID == id);
        }
    }
}
