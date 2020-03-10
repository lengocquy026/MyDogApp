using Microsoft.EntityFrameworkCore;
using MyDogApp.API.Models;

namespace MyDogApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}