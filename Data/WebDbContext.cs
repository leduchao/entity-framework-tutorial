using EnitytFrameworrkTutorial.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnitytFrameworrkTutorial.Data
{
    public class WebDbContext(DbContextOptions<WebDbContext> options) : DbContext(options)
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Borrower> Borrowers { get; set; }


        //public DbSet<XeMay> DanhSachXeMay { get; set; }

        //public DbSet<BienSo> DanhSachBienSo { get; set; }

        public DbSet<LoaiXe> DanhSachLoaiXe { get; set; }
        
        public DbSet<Tinh> DanhSachTinh { get; set; }

        public DbSet<Huyen> DanhSachHuyen { get; set; }

        public DbSet<Xa> DanhSachXa { get; set; }

        public DbSet<Thon> DanhSachThon { get; set; }
    }
}
