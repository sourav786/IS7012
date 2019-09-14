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
    public class IndexModel : PageModel
    {
        private readonly Core_Crud.Models.Core_CrudContext _context;

        public IndexModel(Core_Crud.Models.Core_CrudContext context)
        {
            _context = context;
        }

        public IList<Destination> Destination { get;set; }

        public async Task OnGetAsync()
        {
            Destination = await _context.Destination.ToListAsync();
        }
    }
}
