using System;

namespace Common
{
    public interface ICache
    {
        T GetOrAdd<T>(string key);
    }
    public class Cache : ICache
    {
        public T GetOrAdd<T>(string key)
        {
            return default(T);
        }
    }
}
