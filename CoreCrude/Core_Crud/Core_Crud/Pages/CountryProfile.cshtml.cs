using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_Crud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Core_Crud.Pages
{
    
        public class CountryProfileModel : PageModel
        {
            private Core_Crud0921Context _context;



            public CountryProfileModel(Core_Crud0921Context context)
            {
                _context = context;
            }



            public Country Country { get; set; }
            public IActionResult OnGet(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }
                Country = _context.Country
                            .Include(c => c.Destinations)
                            .FirstOrDefault(c => c.ID == id);
                if (Country == null)
                {
                    return NotFound();
                }
                return Page();
            }
        }
    }
