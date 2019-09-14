using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Core_Crud.Models
{
    public class Core_CrudContext : DbContext
    {
        public Core_CrudContext (DbContextOptions<Core_CrudContext> options)
            : base(options)
        {
        }

        public DbSet<Core_Crud.Models.Destination> Destination { get; set; }
    }
}
