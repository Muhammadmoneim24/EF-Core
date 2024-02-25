using EFCore1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCore1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //External Connection String
            var config = new ConfigurationBuilder().AddJsonFile("appsetting.json").Build();
            var connecctionstring = config.GetSection("constr").Value;

            var optionsBuilder = new DbContextOptionsBuilder();

            optionsBuilder.UseSqlServer(connecctionstring);

            var options = optionsBuilder.Options;

            using ( var comtext = new AppDbContext(options)) 
            {
               foreach(var wallet in comtext.Wallets) 
                {
                    Console.WriteLine(wallet);
                }
            }
        }
    }
}