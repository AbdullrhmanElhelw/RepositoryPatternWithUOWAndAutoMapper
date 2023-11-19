using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithUOW.Infrastructure.InfrastructreBases;

public interface IBaseRepository<T> where T : class
{
    T? Get(int id);
    IEnumerable<T> GetAll { get; }
    T Add(T entity);
    T Update(T entity);
    void Delete(int id);
}
