using Microsoft.EntityFrameworkCore;
using SQLDemoApp.Models;

namespace SQLDemoApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    {

    }
}
