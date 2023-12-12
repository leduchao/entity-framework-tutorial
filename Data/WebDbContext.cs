using EnitytFrameworrkTutorial.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnitytFrameworrkTutorial.Data
{
    public class WebDbContext : DbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }

        public DbSet<XeMay> XeMays { get; set; }
        public DbSet<BienSo> BienSos { get; set; }
    }
}
