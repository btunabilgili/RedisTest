using System.Threading.Tasks;
using System;
using StackExchange.Redis;
using System.Text.Json;

namespace RedisTest
{
    public interface ICacheService
    {
        Task<string> GetValueAsync(string key);
        Task<bool> SetValueAsync(string key, string value, TimeSpan expireTime);
        Task<T> GetOrAddAsync<T>(string key, Func<Task<T>> action, TimeSpan expireTime) where T : class;
        T GetOrAdd<T>(string key, Func<T> action, TimeSpan expireTime) where T : class;
        Task Clear(string key);
        Task ClearAll();
    }

    public sealed class CacheService : ICacheService
    {
        private readonly IConnectionMultiplexer connection;
        private readonly IDatabase cache;
        public CacheService(IConnectionMultiplexer redisCon)
        {
            connection = redisCon ?? throw new ArgumentNullException(nameof(redisCon));
            cache = redisCon.GetDatabase();
        }
        public async Task Clear(string key)
        {
            await cache.KeyDeleteAsync(key);
        }

        public async Task ClearAll()
        {
            var endpoints = connection.GetEndPoints(true);
            foreach (var endpoint in endpoints)
            {
                var server = connection.GetServer(endpoint);
                await server.FlushAllDatabasesAsync();
            }
        }

        public T GetOrAdd<T>(string key, Func<T> action, TimeSpan expireTime) where T : class
        {
            var result = cache.StringGet(key);
            if (result.IsNull)
            {
                result = JsonSerializer.SerializeToUtf8Bytes(action());
                cache.StringSet(key, result, expireTime);
            }
            return JsonSerializer.Deserialize<T>(result);
        }

        public async Task<T> GetOrAddAsync<T>(string key, Func<Task<T>> action, TimeSpan expireTime) where T : class
        {
            var result = await cache.StringGetAsync(key);
            if (result.IsNull)
            {
                result = JsonSerializer.SerializeToUtf8Bytes(await action());
                await SetValueAsync(key, result, expireTime);
            }
            return JsonSerializer.Deserialize<T>(result);
        }

        public async Task<string> GetValueAsync(string key)
        {
            return await cache.StringGetAsync(key);
        }

        public async Task<bool> SetValueAsync(string key, string value, TimeSpan expireTime)
        {
            return await cache.StringSetAsync(key, value, expireTime);
        }
    }
}
