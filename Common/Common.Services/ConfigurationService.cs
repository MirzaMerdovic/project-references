// oy2cegzh5fdevzud652awdtdoaz4yo6ehhygzb5ceubxra
using System;

namespace Common.Services
{
    public interface IConfigurationService
    {
        T GetConfiguration<T>(string key);
    }

    public class ConfigurationService : IConfigurationService
    {
        private readonly ICache _cache;

        public ConfigurationService(ICache cache)
        {
            _cache = cache;
        }

        public T GetConfiguration<T>(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException(nameof(key));

            return _cache.GetOrAdd<T>(key);
        }
    }
}