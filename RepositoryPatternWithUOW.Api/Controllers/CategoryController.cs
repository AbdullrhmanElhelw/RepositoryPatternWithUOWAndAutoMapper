using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWithUOW.DataService.Abstracts;
using RepositoryPatternWithUOW.DataService.DTOs.CategoriesDTOs;

namespace RepositoryPatternWithUOW.api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult<CategoryReadDTO> GetCategory(int id )=> 
            _categoryService.GetCategory(id) 
             is CategoryReadDTO categoryReadDTO 
             ? Ok(categoryReadDTO) : NotFound();

        [HttpGet]
        public ActionResult<CategoryWithBooksReadDTO> GetCategoryWithBooks(int id)=> 
            _categoryService.GetCategoryWithBooks(id) 
             is CategoryWithBooksReadDTO categoryWithBooksReadDTO 
             ? Ok(categoryWithBooksReadDTO) : NotFound();

        [HttpGet]
        public ActionResult<CategoryWtihBooksAndAuthorReadDTO> GetCategoryWithBooksWithAuthor(int id)=>
            _categoryService.GetCategoryWtihBooksAndAuthor(id) 
             is CategoryWtihBooksAndAuthorReadDTO categoryWtihBooksAndAuthorReadDTO 
             ? Ok(categoryWtihBooksAndAuthorReadDTO) : NotFound();

        [HttpGet]
        public ActionResult<IEnumerable<CategoryReadDTO>>GetCategories()=>
            Ok(_categoryService.GetCategories());

        [HttpGet]
        public ActionResult<IEnumerable<CategoryWithBooksReadDTO>> GetCategoriesWithBooks()=>
            Ok(_categoryService.GetCategoriesWithBooks());

        [HttpGet]
        public ActionResult<IEnumerable<CategoryWtihBooksAndAuthorReadDTO>> GetCategoriesWithBooksWithAuthor()=>
            Ok(_categoryService.GetCategoriesWithBooksAndAuthor());

        [HttpGet]
        public ActionResult<CategoryReadDTO> FindCategory(string name) =>
            _categoryService.FindCategories(c =>
            string.Equals(c.Name, name, StringComparison.OrdinalIgnoreCase))
            is CategoryReadDTO categoryReadDTO
                ? Ok(categoryReadDTO)
                : NotFound();
        [HttpPost]
        public ActionResult<CategoryCreateDTO> CreateCategory(CategoryCreateDTO categoryCreateDTO) =>
            _categoryService.CreateCategory(categoryCreateDTO) is CategoryCreateDTO category
                ? Ok(category)
                : BadRequest();


    }
}
