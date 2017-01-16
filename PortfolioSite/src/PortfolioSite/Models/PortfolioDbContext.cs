using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PortfolioSite.Models
{
    public class PortfolioDbContext : DbContext
    {
        private IConfigurationRoot _config;

        public PortfolioDbContext(IConfigurationRoot config, DbContextOptions dbOptions) : base(dbOptions)
        {
            _config = config;
        }

        public DbSet<ProjectDetails> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);
        }
    }
}
