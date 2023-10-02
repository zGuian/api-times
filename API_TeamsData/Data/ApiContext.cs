using API_TeamsData.Models;
using Microsoft.EntityFrameworkCore;

namespace API_TeamsData.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        public DbSet<Times> Times { get; set; }
    }
}
