using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RepositoryPatternWithUOW.DataService.DTOs.BooksDTO;
using RepositoryPatternWithUOW.Infrastructure.UnitOfWork;

namespace RepositoryPatternWithUOW.api.Filters
{
    public class CheckBookEsistesFilter : ActionFilterAttribute
    {
        private readonly IUnitOfWork _unitOfWork;

        public CheckBookEsistesFilter(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var book = context.ActionArguments["bookCreateDTO"] as BookCreateDTO;
            if(book is not null)
            {

                var bookExists = _unitOfWork.BookRepository.FindBook(b => string.Equals(b.Title, book.Title, StringComparison.OrdinalIgnoreCase)); 
                if (book is not null)
                {
                    context.Result = new BadRequestObjectResult("Book already exists");
                }
            }
        }


    }
}
