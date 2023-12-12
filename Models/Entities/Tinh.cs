using System.ComponentModel.DataAnnotations;

namespace EnitytFrameworrkTutorial.Models.Entities
{
    public class Tinh
    {
        [Key]
        public int MaTinh { get; set; }

        public string TenTinh { get; set; }  = string.Empty;

        public virtual IEnumerable<Huyen> DanhSachHuyen { get; set; } = new List<Huyen>();

    }
}
