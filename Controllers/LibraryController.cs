using EnitytFrameworrkTutorial.Data;
using EnitytFrameworrkTutorial.Models.DTOs;
using EnitytFrameworrkTutorial.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace EnitytFrameworrkTutorial.Controllers;

[Route("api/library")]
[ApiController]
public class LibraryController : ControllerBase
{
    private readonly WebDbContext _context;

    public LibraryController(WebDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("get-all-books")]
    public async Task<ActionResult<List<Book>>> GetAllBooks()
    {
        if (_context.Books == null)
            return BadRequest();

        var listBooks = await _context.Books
            .Include(b => b.Author)
            .Include(b => b.Borrowers)
            .Select(b => new
            {
                BookId = b.Id,
                BookName = b.Name,
                BookAuthor = b.Author!.PenName,
                BorrowersList = b.Borrowers.ToList()
            })
            .ToListAsync();

        if (listBooks == null || listBooks.Count == 0)
            return NotFound("There are no any book in library!");

        return Ok(listBooks);
    }

    [HttpPost]
    [Route("create-book")]
    public async Task<ActionResult<Book>> CreateBook(BookDTO bookDTO)
    {
        if (_context.Books == null)
            return BadRequest();

        var newBook = new Book
        {
            Name = bookDTO.Name,
        };

        var existAuthor = _context.Authors?
                .FirstOrDefault(a =>
                    a.PenName.Trim().ToLower() == bookDTO.AuthorPenName.Trim().ToLower());

        if (existAuthor == null)
        {
            var newAuthor = new Author
            {
                PenName = bookDTO.AuthorPenName,
            };

            newBook.Author = newAuthor;
            newAuthor.Books.Add(newBook);
        }
        else
        {
            newBook.Author = existAuthor;
            existAuthor.Books.Add(newBook);
        }

        _context.Books.Add(newBook);
        await _context.SaveChangesAsync();

        return Ok(bookDTO);
    }

    [HttpGet]
    [Route("get-all-authors")]
    public async Task<ActionResult<List<Author>>> GetAllAuthors()
    {
        return Ok(await _context.Authors!
            .Include(a => a.Books)
        .Select(a => new
        {
            AuthorId = a.Id,
            AuthorPenName = a.PenName,
            BookNames = a.Books.Select(b => b.Name).ToList(),
        })
        .ToListAsync());
    }

    [HttpPost]
    [Route("create-author")]
    public async Task<ActionResult<Book>> CreateAuthor(AuthorDTO request)
    {
        if (_context.Authors == null)
            return BadRequest();

        var newAuthor = new Author
        {
            PenName = request.PenName,
        };

        var bookList = new List<Book>
            {
                new() { Name = "book1", Author = newAuthor },
                new() { Name = "book2", Author = newAuthor },
                new() { Name = "book3", Author = newAuthor },
                new() { Name = "book4", Author = newAuthor },
            };

        newAuthor.Books = bookList;

        _context.Authors.Add(newAuthor);
        await _context.SaveChangesAsync();

        return Ok(request);
    }
}
