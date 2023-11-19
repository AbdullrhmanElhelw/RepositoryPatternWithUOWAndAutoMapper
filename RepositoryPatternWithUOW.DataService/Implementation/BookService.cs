
using AutoMapper;
using RepositoryPatternWithUOW.DataService.Abstracts;
using RepositoryPatternWithUOW.DataService.DTOs.BooksDTO;
using RepositoryPatternWithUOW.Entities.Models;
using RepositoryPatternWithUOW.Infrastructure.UnitOfWork;

namespace RepositoryPatternWithUOW.DataService.Implementation;

public class BookService : IBookService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public BookService(IUnitOfWork unitOfWork , IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public BookCreateDTO? CreateBook(BookCreateDTO book)
    {
        var bookModel = _mapper.Map<Book>(book);
        _unitOfWork.BookRepository.Add(bookModel);
        _unitOfWork.SaveChanges();
        return _mapper.Map<BookCreateDTO>(bookModel);
    }

    public void DeleteBook(int id)
    {
        var bookToDelete = _unitOfWork.BookRepository.Get(id);
        _unitOfWork.BookRepository.Delete(id);
        _unitOfWork.SaveChanges();
    }

    public BookReadDTO? FindBook(Func<BookReadDTO, bool> critiria)
    {    
        Func<Book,bool> condation = book=> critiria(_mapper.Map<BookReadDTO>(book));
        var book = _unitOfWork.BookRepository.FindBook(condation);
        return _mapper.Map<BookReadDTO>(book);
    }

    public BookReadDTO? GetBook(int id)  => 
        _mapper.Map<BookReadDTO>(_unitOfWork.BookRepository.Get(id));

    public IEnumerable<BookReadDTO> GetBooks() => _mapper.Map<IEnumerable<BookReadDTO>>(_unitOfWork.BookRepository.GetAll);

    public BookWithAuthorReadDTO? GetBookWithAuthor(int id) =>
        _mapper.Map<BookWithAuthorReadDTO>(_unitOfWork.BookRepository.GetBookWithAuthor(id));

    public BookUpdateDTO? UpdateBook(BookUpdateDTO book)
    {
        var bookToUpdate = _unitOfWork.BookRepository.Get(book.Id);
        if(bookToUpdate is not null)
        {
            _mapper.Map(book,bookToUpdate);
            _unitOfWork.BookRepository.Update(bookToUpdate);
            _unitOfWork.SaveChanges();
        }
        return _mapper.Map<BookUpdateDTO>(bookToUpdate);
    }
}
