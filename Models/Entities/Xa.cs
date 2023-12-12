using System.ComponentModel.DataAnnotations;

namespace EnitytFrameworrkTutorial.Models.Entities
{
    public class Xa
    {
        [Key]
        public int MaXa { get; set; }

        public string TenXa { get; set; } = string.Empty;

        public int MaHuyen { get; set; }

        public Huyen Huyen { get; set; } = new();

        public virtual IEnumerable<Thon> DanhSachThon { get; set; } = new List<Thon>();
    }
}
