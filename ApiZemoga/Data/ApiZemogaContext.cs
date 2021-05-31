using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiZemoga.Models;

namespace ApiZemoga.Data
{
    public class ApiZemogaContext : DbContext
    {
        public ApiZemogaContext (DbContextOptions<ApiZemogaContext> options)
            : base(options)
        {
        }

        public DbSet<ApiZemoga.Models.Blog> Blog { get; set; }
    }
}
