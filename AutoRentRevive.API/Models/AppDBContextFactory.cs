//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.Extensions.Configuration;
//using System.IO;

//namespace AutoRentRevive.API.Models
//{
//    public class AppDBContextFactory : IDesignTimeDbContextFactory<AppDBContext>
//    {
//        public AppDBContext CreateDbContext(string[] args)
//        {
//            // Read config from appsettings.json manually
//            IConfigurationRoot configuration = new ConfigurationBuilder()
//                .SetBasePath(Directory.GetCurrentDirectory())
//                .AddJsonFile("appsettings.json")
//                .Build();

//            var optionsBuilder = new DbContextOptionsBuilder<AppDBContext>();
//            var connectionString = configuration.GetConnectionString("DefaultConnection");

//            optionsBuilder.UseSqlServer(connectionString);

//            return new AppDBContext(optionsBuilder.Options);
//        }
//    }
//}
