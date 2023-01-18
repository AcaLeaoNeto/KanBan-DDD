using Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class DbContent : DbContext
    {
        public DbContent(DbContextOptions<DbContent> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=KanbanDDD;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Board> boards { get; set; }
        public DbSet<Tasks> tasks { get; set; }
    }
}
