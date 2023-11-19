using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWithUOW.api.Filters;
using RepositoryPatternWithUOW.DataService.Abstracts;
using RepositoryPatternWithUOW.DataService.DTOs.AuthorDTOs;

namespace RepositoryPatternWithUOW.api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class AuthorController : ControllerBase
{
    private readonly IAuthorService _authorService;

    public AuthorController(IAuthorService authorService )
    {
        _authorService = authorService;
    }

    [HttpGet]
    public ActionResult<AuthorReadDTO> GetAuthor(int id)
    {
        var author = _authorService.GetAuthor(id);
        if (author is null)
        {
            return NotFound();
        }
        return Ok(author);
    }

    [HttpGet]
    public ActionResult<AuthorReadWithBook> GetAuthorWithBooks(int id)
    {
        var author = _authorService.GetAuthorWithBooks(id);
        if (author is null)
        {
            return NotFound();
        }
        return Ok(author);
    }

    [HttpPost]
    [ServiceFilter(typeof(CheckUserExistsFilter))]
    public ActionResult<AuthorCreateDTO> CreateAuthor(AuthorCreateDTO authorCreateDTO)
    {
        if(authorCreateDTO is not null)
        {
            _authorService.CreateAuthor(authorCreateDTO);
            return CreatedAtAction(nameof(FindAuthorByName), new {name = authorCreateDTO.Name});
        }
        return BadRequest();
    }

    [HttpGet]
    public ActionResult<IEnumerable<AuthorReadDTO>> GetAuthors()
    {
        var authors = _authorService.GetAuthors();
        return Ok(authors);
    }

    [HttpGet]
    public ActionResult<AuthorReadDTO> FindAuthorByName(string name)
    {
        var author = _authorService.FindAuthor(a=>a.FullName.Contains(name));
        if (author is null)
        {
            return NotFound();
        }
        return Ok(author);
    }

    [HttpGet]
    public ActionResult<AuthorReadWithBook> FindAuthorWithBookByName(string name)
        => Ok(_authorService.FindAuthorWithBooks(a => a.FullName.Contains(name)));

    [HttpDelete]
    public ActionResult<string> DeleteAuthor(int id)
    {
        _authorService.DeleteAuthor(id);
        return Ok("Author Deleted");
    }

    [HttpPut]
    public ActionResult<AuthorUpdateDTO> UpdateAuthor(AuthorUpdateDTO authorUpdateDTO)
    {
        var author = _authorService.UpdateAuthor(authorUpdateDTO);
        return CreatedAtAction(nameof(FindAuthorByName), new {name = authorUpdateDTO.Name});
    }


}
