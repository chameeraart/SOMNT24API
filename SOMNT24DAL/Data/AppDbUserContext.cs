using Microsoft.EntityFrameworkCore;
using SOMNT24DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMNT24DAL.Data
{

    public class AppDbUserContext : DbContext
    {
        public AppDbUserContext(DbContextOptions<AppDbUserContext> options) : base(options)
        {
        }

        public DbSet<ZYUser> ZYUser { get; set; }
    }
}
