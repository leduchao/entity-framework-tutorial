using System.ComponentModel.DataAnnotations;

namespace EnitytFrameworrkTutorial.Models.Entities
{
    public class Thon
    {
        [Key]
        public int MaThon { get; set; }

        public string TenThon { get; set; } = string.Empty;

        public int MaXa { get; set; }

        public virtual Xa Xa { get; set; } = new();
    }
}
