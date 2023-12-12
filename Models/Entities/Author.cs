﻿namespace EnitytFrameworrkTutorial.Models.Entities;

public class Author
{
    public int Id { get; set; }
    public string PenName { get; set; } = string.Empty;

    public List<Book> Books { get; set; } = [];
}
