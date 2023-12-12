using System.ComponentModel.DataAnnotations;

namespace EnitytFrameworrkTutorial.Models.Entities
{
    public class Huyen
    {
        [Key]
        public int MaHuyen { get; set; }

        public string TenHuyen { get; set; } = string.Empty;

        public int MaTinh { get; set; }

        public virtual Tinh Tinh { get; set; } = new();

        public virtual IEnumerable<Xa> DanhSachXa { get; set; } = new List<Xa>();
    }
}
