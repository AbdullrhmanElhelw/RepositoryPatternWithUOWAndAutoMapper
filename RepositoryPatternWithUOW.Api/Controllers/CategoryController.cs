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
        private readonly ICacheService _cacheService;

        public CategoryController(ICategoryService categoryService, ICacheService cacheService)
        {
            _categoryService = categoryService;
            _cacheService = cacheService;
        }

        [HttpGet]
        public ActionResult<CategoryReadDTO> GetCategory(int id )
        {
            var category = _cacheService.Get<CategoryReadDTO>($"category-{id}");
            if(category is not null)
                return Ok(category);
            category = _categoryService.GetCategory(id);
            _cacheService.SetData($"category-{id}", category, DateTimeOffset.Now.AddSeconds(30));
            return Ok(category);
        }

        [HttpGet]
        public ActionResult<CategoryWithBooksReadDTO> GetCategoryWithBooks(int id)
        {
            var category = _cacheService.Get<CategoryWithBooksReadDTO>($"categoryWithBooks-{id}");
            if(category is not null)
                return Ok(category);
            category = _categoryService.GetCategoryWithBooks(id);
            _cacheService.SetData($"categoryWithBooks-{id}", category, DateTimeOffset.Now.AddSeconds(30));
            return Ok(category);
        }

        [HttpGet]
        public ActionResult<CategoryWtihBooksAndAuthorReadDTO> GetCategoryWithBooksWithAuthor(int id)
        {
            var category = _cacheService.Get<CategoryWtihBooksAndAuthorReadDTO>($"categoryWithBooksAndAuthor-{id}");
            if(category is not null)
                return Ok(category);
            category = _categoryService.GetCategoryWtihBooksAndAuthor(id);
            _cacheService.SetData($"categoryWithBooksAndAuthor-{id}", category, DateTimeOffset.Now.AddSeconds(30));
            return Ok(category);
        }

        [HttpGet]
        public ActionResult<IEnumerable<CategoryReadDTO>> GetCategories()
        {
            var categories = _cacheService.Get<IEnumerable<CategoryReadDTO>>("categories");
            if(categories is not null && categories.Count()>0 )
                return Ok(categories);

            categories = _categoryService.GetCategories();
            _cacheService.SetData("categories", categories, DateTimeOffset.Now.AddSeconds(30));
            return Ok(categories);
        }
          
        [HttpGet]
        public ActionResult<IEnumerable<CategoryWithBooksReadDTO>> GetCategoriesWithBooks()
        {
            var categories = _cacheService.Get<IEnumerable<CategoryWithBooksReadDTO>>("categoriesWithBooks");
            if(categories is not null && categories.Count()>0 )
                return Ok(categories);

            categories = _categoryService.GetCategoriesWithBooks();
            _cacheService.SetData("categoriesWithBooks", categories, DateTimeOffset.Now.AddSeconds(30));
            return Ok(categories);
        }

        [HttpGet]
        public ActionResult<IEnumerable<CategoryWtihBooksAndAuthorReadDTO>> GetCategoriesWithBooksWithAuthor()
        {
            var catgeories = _cacheService.Get<IEnumerable<CategoryWtihBooksAndAuthorReadDTO>>("categoriesWithBooksAndAuthor");
            if(catgeories is not null && catgeories.Count()>0 )
                return Ok(catgeories);
            catgeories = _categoryService.GetCategoriesWithBooksAndAuthor();
            _cacheService.SetData("categoriesWithBooksAndAuthor", catgeories, DateTimeOffset.Now.AddSeconds(30));
            return Ok(catgeories);
        }

        [HttpGet]
        public ActionResult<CategoryReadDTO> FindCategory(string name)
        {
            var category = _cacheService.Get<CategoryReadDTO>($"category-{name}");  
            if(category is not null)
                return Ok(category);

            category = _categoryService.FindCategory(c=>string.Equals(name,category?.Name,StringComparison.OrdinalIgnoreCase));
            _cacheService.SetData($"category-{name}", category, DateTimeOffset.Now.AddSeconds(30));
            return Ok(category);
        }

        [HttpPost]
        public ActionResult<CategoryCreateDTO> CreateCategory(CategoryCreateDTO categoryCreateDTO) =>
            _categoryService.CreateCategory(categoryCreateDTO) is CategoryCreateDTO category
                ? Ok(category)
                : BadRequest();


    }
}
