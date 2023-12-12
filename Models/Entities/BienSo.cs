using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace EnitytFrameworrkTutorial.Models.Entities
{
    public class BienSo
    {
        [Key]
        public int MaBienSo { get; set; }
        public int MaTinh { get; set; }
        public string MaHuyen { get; set; } = string.Empty;
        public int SoDinhDanh { get; set; }
        public string ChuoiDinhDanh { get; set; } = string.Empty;

        [ForeignKey("XeMay")]
        public int MaXeMay { get; set; }
        public XeMay XeMay { get; set; } = null!;
    }
}
