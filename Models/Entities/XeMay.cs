using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnitytFrameworrkTutorial.Models.Entities
{
    public class XeMay
    {
        [Key]
        public int MaXe { get; set; }

        public string TenXe { get; set; } = string.Empty;

        public int PhanKhoi { get; set; }

        public virtual BienSo BienSo { get; set; } = new();
    }
}
