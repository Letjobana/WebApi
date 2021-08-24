using Microsoft.AspNetCore.Mvc;
using my_books.Data.Models;
using my_books.Data.Services;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _bookService;
        public BooksController(BooksService booksService)
        {
            _bookService = booksService;
        }
        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks()
        {
            var allBooks = _bookService.GetAllBooks();
            return Ok(allBooks);
        }
        [HttpGet("get-a sigle-book/{id}")]
        public IActionResult GetBook(int id)
        {
            var book = _bookService.GetBookById(id);
            return Ok(book);
        }
        [HttpPost("add-book-with authors")]
        public IActionResult AddBook([FromBody] BookVM book)
        {
            _bookService.AddBookWithAuthors(book);
            return Ok();
        }
        [HttpPut("update-bookby-Id/{id}")]
        public IActionResult UpdateBookById(int id, [FromBody] BookVM book)
        {
            var updateBook = _bookService.UpdateBookById(id, book);
            return Ok(updateBook);
        }
        [HttpDelete("delete-bookby-Id/{id}")]
        public IActionResult UpdateBookById(int id)
        {
            _bookService.DeleteBookById(id);
            return Ok();
        }

    }
}
