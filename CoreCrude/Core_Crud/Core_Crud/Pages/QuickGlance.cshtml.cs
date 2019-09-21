using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_Crud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Core_Crud.Pages
{
    public class QuickGlanceModel : PageModel
    {
        private Core_Crud.Models.Core_Crud0921Context _context;
        public QuickGlanceModel(Core_Crud.Models.Core_Crud0921Context context)
        {
            _context = context;
        }
        public ICollection<Destination> Destinations { get; set; }
        public void OnGet()
        {
            Destinations = _context.Destination.OrderByDescending(x => x.Arrival_Date).ToList();

        }
    }
}