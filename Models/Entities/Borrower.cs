namespace EnitytFrameworrkTutorial.Models.Entities
{
    public class Borrower
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Book> BooksBorrowed { get; set; } = new ();
    }
}
