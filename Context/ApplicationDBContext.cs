using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fuela_clients.Context
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options)
            : base(options)
        {

        }
        public DbSet<Books> Books { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-FA4I5Q1\\SQLEXPRESS;Database=myDataBase;Trusted_Connection=True;");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
