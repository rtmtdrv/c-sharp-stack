using Microsoft.EntityFrameworkCore;

namespace csharp_belt_exam.Models 
{
    public class MyContext : DbContext
    {
        public MyContext (DbContextOptions options) : base(options) {}
        public DbSet<User> Users {get;set;}
    }
}