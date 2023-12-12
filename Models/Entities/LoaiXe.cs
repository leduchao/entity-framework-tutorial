using System.ComponentModel.DataAnnotations;

namespace EnitytFrameworrkTutorial.Models.Entities
{
    public class LoaiXe
    {
        [Key]
        public int MaLoaiXe { get; set; }

        public string TenLoaiXe { get; set; } = string.Empty;
    }
}
