using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Core_Crud.Models;

namespace Core_Crud.Pages.Destinations
{
    public class DetailsModel : PageModel
    {
        private readonly Core_Crud.Models.Core_CrudContext _context;

        public DetailsModel(Core_Crud.Models.Core_CrudContext context)
        {
            _context = context;
        }

        public Destination Destination { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Destination = await _context.Destination.FirstOrDefaultAsync(m => m.ID == id);

            if (Destination == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
