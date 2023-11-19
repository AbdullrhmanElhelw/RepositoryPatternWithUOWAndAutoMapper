using RepositoryPatternWithUOW.Infrastructure.Context;

namespace RepositoryPatternWithUOW.Infrastructure.InfrastructreBases;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;

    public BaseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<T> GetAll => _context.Set<T>().ToList();

    public T Add(T entity) => _context.Set<T>().Add(entity).Entity;

    public void Delete(int id) => _context.Set<T>().Remove(Get(id));

    public T? Get(int id) => _context.Set<T>().Find(id);

    public T Update(T entity) => _context.Set<T>().Update(entity).Entity;
}
