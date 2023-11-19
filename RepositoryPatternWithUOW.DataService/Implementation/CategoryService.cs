using AutoMapper;
using RepositoryPatternWithUOW.DataService.Abstracts;
using RepositoryPatternWithUOW.DataService.DTOs.CategoriesDTOs;
using RepositoryPatternWithUOW.Entities.Models;
using RepositoryPatternWithUOW.Infrastructure.UnitOfWork;

namespace RepositoryPatternWithUOW.DataService.Implementation;

public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CategoryService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public CategoryCreateDTO CreateCategory(CategoryCreateDTO categoryCreateDTO)
    {
       var category = _mapper.Map<Category>(categoryCreateDTO);
        _unitOfWork.CategoryRepository.Add(category);
        _unitOfWork.SaveChanges();
        return _mapper.Map<CategoryCreateDTO>(category);
    }

    public IEnumerable<CategoryReadDTO> FindCategories(Func<CategoryWtihBooksAndAuthorReadDTO, bool> predicate)
    {
        Func<Category, bool> categoryPredicate = c => predicate(_mapper.Map<CategoryWtihBooksAndAuthorReadDTO>(c));
        return _mapper.Map<IEnumerable<CategoryReadDTO>>(_unitOfWork.CategoryRepository.FindCategories(categoryPredicate));
    }

    public IEnumerable<CategoryReadDTO> GetCategories()=>
        _mapper.Map<IEnumerable<CategoryReadDTO>>(_unitOfWork.CategoryRepository.GetCategoriesWithBooks());

    public IEnumerable<CategoryWithBooksReadDTO> GetCategoriesWithBooks() =>
        _mapper.Map<IEnumerable<CategoryWithBooksReadDTO>>(_unitOfWork.CategoryRepository.GetCategoriesWithBooks());

    public IEnumerable<CategoryWtihBooksAndAuthorReadDTO> GetCategoriesWithBooksAndAuthor() =>
        _mapper.Map<IEnumerable<CategoryWtihBooksAndAuthorReadDTO>>(_unitOfWork.CategoryRepository.GetCategoriesWithBooksAndAuthors());

    public CategoryReadDTO? GetCategory(int id)=> 
        _mapper.Map<CategoryReadDTO>(_unitOfWork.CategoryRepository.GetCategoryWithBooks(id));

    public CategoryWithBooksReadDTO GetCategoryWithBooks(int id) =>
        _mapper.Map<CategoryWithBooksReadDTO>(_unitOfWork.CategoryRepository.GetCategoryWithBooks(id));

    public CategoryWtihBooksAndAuthorReadDTO GetCategoryWtihBooksAndAuthor(int id) =>
        _mapper.Map<CategoryWtihBooksAndAuthorReadDTO>(_unitOfWork.CategoryRepository.GetCategoryWithBooksAndAuthors(id));
}
