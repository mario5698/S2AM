using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiServerFlutterOdisend.Models;

namespace ApiServerFlutterOdisend.Data
{
    public class ApiServerFlutterOdisendContext : DbContext
    {
        public ApiServerFlutterOdisendContext (DbContextOptions<ApiServerFlutterOdisendContext> options)
            : base(options)
        {
        }

        public DbSet<ApiServerFlutterOdisend.Models.Riders> Riders { get; set; }

        public DbSet<ApiServerFlutterOdisend.Models.Routes> Routes { get; set; }

        public DbSet<ApiServerFlutterOdisend.Models.Users> Users { get; set; }

        public DbSet<ApiServerFlutterOdisend.Models.Tasks> Tasks { get; set; }
    }
}
