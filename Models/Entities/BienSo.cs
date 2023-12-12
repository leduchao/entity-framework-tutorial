using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace EnitytFrameworrkTutorial.Models.Entities
{
    public class BienSo
    {
        [Key]
        public int MaBienSo { get; set; }

        [ForeignKey("Tinh")]
        public int MaTinh { get; set; }

        public virtual Tinh Tinh { get; set; } = new();

        //[ForeignKey("Huyen")]
        public int MaHuyen { get; set; }

        public virtual Huyen Huyen { get; set; } = new();

        public int SoDinhDanh { get; set; }

        public string ChuoiDinhDanh => $"{MaTinh} - {MaHuyen} - {SoDinhDanh}";

        [ForeignKey("XeMay")]
        public int MaXeMay { get; set; }

        public virtual XeMay XeMay { get; set; } = new();
    }
}
