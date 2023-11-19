using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RepositoryPatternWithUOW.DataService.DTOs.AuthorDTOs;
using RepositoryPatternWithUOW.Infrastructure.UnitOfWork;

namespace RepositoryPatternWithUOW.api.Filters;

public class CheckUserExistsFilter : ActionFilterAttribute
{
    private readonly IUnitOfWork _unitOfWork;

    public CheckUserExistsFilter(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var author = context.ActionArguments["authorCreateDTO"] as  AuthorCreateDTO;
        if(author is not null)
        {
            var authorExists = _unitOfWork.AuthorRepository.FindAuthor(a => $"{a.Name} {a.Surname} " == $"{author.Name} {author.SurName}");
            if(authorExists is not null)
            {
                context.Result = new BadRequestObjectResult("Author already exists");
            }
        }
    }
}
