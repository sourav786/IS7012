using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_Crud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Core_Crud.Pages
{
    public class IndexModel : PageModel
    {
        private Core_Crud0921Context _context;

        public IndexModel(Core_Crud0921Context context)
        {
            _context = context;
        }

        public ICollection<Destination> Destinations { get; set; }

        public void OnGet()
        {
            CountNoOfBreakfast = _context.Destination.Where(x => x.Has_breakfast == true).Count();
            CountNoOfNoBreakfast = _context.Destination.Where(x => x.Has_breakfast == false).Count();
        }

        public int CountNoOfBreakfast { get; set; }
        public int CountNoOfNoBreakfast { get; set; }
    }
}
