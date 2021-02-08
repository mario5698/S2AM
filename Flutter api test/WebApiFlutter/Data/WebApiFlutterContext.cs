using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiFlutter.Models;

namespace WebApiFlutter.Data
{
    public class WebApiFlutterContext : DbContext
    {
        public WebApiFlutterContext (DbContextOptions<WebApiFlutterContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiFlutter.Models.Users> Users { get; set; }

        public DbSet<WebApiFlutter.Models.Riders> Riders { get; set; }

        public DbSet<WebApiFlutter.Models.Tasks> Tasks { get; set; }
    }
}
