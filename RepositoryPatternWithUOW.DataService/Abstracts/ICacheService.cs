namespace RepositoryPatternWithUOW.DataService.Abstracts;

public interface ICacheService
{
    T? Get<T>(string key);
    bool SetData<T>(string key, T data, DateTimeOffset expirationTime);
    object Remove(string key);  
}
