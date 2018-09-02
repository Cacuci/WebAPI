using Microsoft.EntityFrameworkCore.Design;
using WebAPI.Controllers.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WebAPI.DBContext
{
    // public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<UserDBContext>
    // {
    //     public UserDBContext CreateDbContext(string[] args)
    //     {
    //         IConfigurationRoot configuration = new ConfigurationBuilder()
    //             .SetBasePath(Directory.GetCurrentDirectory())
    //             .AddJsonFile("appsettings.json")
    //             .Build();

    //         var builder = new DbContextOptionsBuilder<UserDBContext>();

    //         var connectionString = configuration.GetConnectionString("DefaultConnection");

    //         builder.UseSqlServer(connectionString);

    //         return new UserDBContext(builder.Options);
    //     }
    // }
}