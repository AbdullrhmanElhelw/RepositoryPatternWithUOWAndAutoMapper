using RepositoryPatternWithUOW.DataService.Abstracts;
using StackExchange.Redis;
using System.Text.Json;

namespace RepositoryPatternWithUOW.DataService.Implementation;

public class CacheService : ICacheService
{
    private readonly IDatabase _cacheDb;

    public CacheService(IDatabase cacheDb)
    {
       var redis = ConnectionMultiplexer.Connect("localhost:6379");
        _cacheDb = redis.GetDatabase();
    }


    public T? Get<T>(string key)
    {
        var value = _cacheDb.StringGet(key);
        if(value.HasValue)
        {
            return JsonSerializer.Deserialize<T>(value);
        }
        return default;
    }

    public object Remove(string key)
    {
        var exist = _cacheDb.KeyExists(key);
        if(exist)
        {
            return _cacheDb.KeyDelete(key);
        }
        return false;
    }

    public bool SetData<T>(string key, T data, DateTimeOffset expirationTime)
    {
        var expire = expirationTime.Subtract(DateTimeOffset.Now);
        return _cacheDb.StringSet(key, JsonSerializer.Serialize(data), expire);
    }
}
