using EFCore1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Wallet> Wallets { get; set; } = null;


        //// Internal Connection String
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //var config = new ConfigurationBuilder().AddJsonFile("appsetting.json").Build();
        //var connecctionstring = config.GetSection("constr").Value;

        //    optionsBuilder.UseSqlServer(connecctionstring);


        //}

        public AppDbContext(DbContextOptions options): base(options)
        {
            
        }
    }
}
