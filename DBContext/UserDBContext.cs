using Microsoft.EntityFrameworkCore;
using WebAPI.Controllers.Models;

namespace WebAPI.Controllers.DBContext
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
                        
        }
        public DbSet<Users> User { get; set; }
    }
}