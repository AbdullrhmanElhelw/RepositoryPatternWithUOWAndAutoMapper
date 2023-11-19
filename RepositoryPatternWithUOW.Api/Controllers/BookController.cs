using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWithUOW.api.Filters;
using RepositoryPatternWithUOW.DataService.Abstracts;
using RepositoryPatternWithUOW.DataService.DTOs.AuthorDTOs;
using RepositoryPatternWithUOW.DataService.DTOs.BooksDTO;

namespace RepositoryPatternWithUOW.api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
           _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<BookReadDTO> GetBook(int id) => _bookService.GetBook(id)
            is BookReadDTO bookReadDTO ? Ok(bookReadDTO) : NotFound();

        [HttpGet]
        public ActionResult<BookReadDTO> FindBookByTitle(string title) 
            => _bookService.FindBook(b=>b.Title.Contains(title))
            is BookReadDTO bookReadDTO ? Ok(bookReadDTO) : NotFound();

        [HttpGet]
        public ActionResult<BookWithAuthorReadDTO> GetBookWithAuthor(int id)=>
            _bookService.GetBookWithAuthor(id)
            is BookWithAuthorReadDTO bookWithAuthorReadDTO ? Ok(bookWithAuthorReadDTO) : NotFound();

        [HttpGet]
        public ActionResult<List<BookReadDTO>> GetBooks() => Ok(_bookService.GetBooks());

        [HttpPut]
        public ActionResult<BookUpdateDTO> UpdateBook(BookUpdateDTO bookUpdateDTO)
        {
            if(bookUpdateDTO is not null)
            {
                _bookService.UpdateBook(bookUpdateDTO);
                return Ok(bookUpdateDTO);
            }
            return BadRequest();
        }


        [HttpPost]
        [ServiceFilter(typeof(CheckBookEsistesFilter))]
        public ActionResult<BookCreateDTO> CreateBook(BookCreateDTO bookCreateDTO)
        {
            if(bookCreateDTO is not null)
            {
                _bookService.CreateBook(bookCreateDTO);
                return Ok(bookCreateDTO);
            }
            return BadRequest();
        }

        [HttpDelete]
        public ActionResult<string> DeleteBook(int id)
        {
            var book = _bookService.GetBook(id);
            if(book is not null)
            {
                _bookService.DeleteBook(id);
                return Ok("Book Deleted");
            }
            return NotFound();
        }



    }
}
