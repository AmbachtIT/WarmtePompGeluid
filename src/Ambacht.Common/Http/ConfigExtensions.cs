using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Ambacht.Common.Http
{
    public static class ConfigExtensions
    {

        public static string GetBaseAddress(this IConfiguration configuration, string key)
        {
            var value = configuration[key];
            if (string.IsNullOrEmpty(value))
            {
                throw new InvalidOperationException($"Base address {key} has not been configured");
            }

            if (!value.EndsWith("/"))
            {
                throw new InvalidOperationException($"Base address {key} should end with a trailing slash");
            }

            return value;
        }

    }
}
