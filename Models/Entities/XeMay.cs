using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnitytFrameworrkTutorial.Models.Entities
{
    public class XeMay
    {
        [Key]
        public int MaXe { get; set; }
        public string TenXe { get; set; } = string.Empty;

        public BienSo? BienSo { get; set; }
    }
}
