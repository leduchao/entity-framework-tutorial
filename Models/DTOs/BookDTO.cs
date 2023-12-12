using EnitytFrameworrkTutorial.Models.Entities;

namespace EnitytFrameworrkTutorial.Models.DTOs
{
    public class BookDTO
    {
        public string Name { get; set; } = string.Empty;
        public string AuthorPenName { get; set; } = string.Empty;
        public List<BorrowerDTO> BorrowersList { set; get; } = new();
    }

    //public record struct 
}
