namespace EnitytFrameworrkTutorial.Models.Entities;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    //public decimal Price { get; set; }
    public int AuthorId { get; set; }
    public Author? Author { get; set; }
    public List<Borrower> Borrowers { get; set; } = new();
}
