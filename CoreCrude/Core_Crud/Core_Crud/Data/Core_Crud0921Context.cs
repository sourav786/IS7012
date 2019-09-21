using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core_Crud.Models;

namespace Core_Crud.Models
{
    public class Core_Crud0921Context : DbContext
    {
        public Core_Crud0921Context (DbContextOptions<Core_Crud0921Context> options)
            : base(options)
        {
        }

        public DbSet<Core_Crud.Models.Country> Country { get; set; }

        public DbSet<Core_Crud.Models.Destination> Destination { get; set; }
    }
}
