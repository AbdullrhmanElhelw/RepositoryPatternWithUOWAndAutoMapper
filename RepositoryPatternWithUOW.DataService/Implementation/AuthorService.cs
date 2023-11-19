using AutoMapper;
using RepositoryPatternWithUOW.DataService.Abstracts;
using RepositoryPatternWithUOW.DataService.DTOs.AuthorDTOs;
using RepositoryPatternWithUOW.Entities.Models;
using RepositoryPatternWithUOW.Infrastructure.UnitOfWork;

namespace RepositoryPatternWithUOW.DataService.Implementation;

public class AuthorService : IAuthorService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public AuthorService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public AuthorCreateDTO CreateAuthor(AuthorCreateDTO authorCreateDTO)
    {
        var author = _mapper.Map<Author>(authorCreateDTO);
        _unitOfWork.AuthorRepository.Add(author);
        _unitOfWork.SaveChanges();
        return authorCreateDTO;
    }

    public void DeleteAuthor(int id)
    {
        var authorToDelete = _unitOfWork.AuthorRepository.Get(id);
        if(authorToDelete is not null)
        {
            _unitOfWork.AuthorRepository.Delete(id);
            _unitOfWork.SaveChanges();
        }
    }

    public AuthorReadDTO? FindAuthor(Func<AuthorReadDTO, bool> critria)
    {
        // map from Func<AuthorReadDTO, bool> to Func<Author, bool>
        Func<Author, bool> condition = author => critria(_mapper.Map<AuthorReadDTO>(author));
        var author = _unitOfWork.AuthorRepository.FindAuthor(condition);
        return _mapper.Map<AuthorReadDTO>(author);

    }

    public AuthorReadWithBook? FindAuthorWithBooks(Func<AuthorReadWithBook, bool> critria)
    {
        Func<Author,bool> condation   = author=> critria(_mapper.Map<AuthorReadWithBook>(author));
        var author = _unitOfWork.AuthorRepository.FindAuthor(condation);
        return _mapper.Map<AuthorReadWithBook>(author);
    }

    public AuthorReadDTO? GetAuthor(int id) => _mapper.Map<AuthorReadDTO>(_unitOfWork.AuthorRepository.Get(id));

    public IEnumerable<AuthorReadDTO> GetAuthors() => _mapper.Map<IEnumerable<AuthorReadDTO>>(_unitOfWork.AuthorRepository.GetAll);

    public AuthorReadWithBook? GetAuthorWithBooks(int id) => _mapper.Map<AuthorReadWithBook>(_unitOfWork.AuthorRepository.GetAuthorWithBooks(id));

    public AuthorUpdateDTO UpdateAuthor(AuthorUpdateDTO authorUpdateDTO)
    {
        var authorToUpdate = _unitOfWork.AuthorRepository.Get(authorUpdateDTO.Id);
        if(authorToUpdate is not null)
        {
             _mapper.Map(authorUpdateDTO,authorToUpdate);
            _unitOfWork.AuthorRepository.Update(authorToUpdate);
            _unitOfWork.SaveChanges();
        }
        return authorUpdateDTO;
    }
}
