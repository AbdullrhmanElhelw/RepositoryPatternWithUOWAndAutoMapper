using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RepositoryPatternWithUOW.DataService.DTOs.CategoriesDTOs;
using RepositoryPatternWithUOW.Infrastructure.UnitOfWork;

namespace RepositoryPatternWithUOW.api.Filters;

public class CheckCategoryExistsFilter : ActionFilterAttribute
{
    private readonly IUnitOfWork _unitOfWork;

    public CheckCategoryExistsFilter(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var category = context.ActionArguments["categoryCreateDTO"] as CategoryCreateDTO;
        if(category is not null)
        {
            var categoryExists = _unitOfWork.CategoryRepository.FindCategory(c => string.Equals(c.Name, category.Name, StringComparison.OrdinalIgnoreCase));
            if(categoryExists is not null)
            {
                context.Result = new BadRequestObjectResult("Category already exists");
            }
        }
    }

}
