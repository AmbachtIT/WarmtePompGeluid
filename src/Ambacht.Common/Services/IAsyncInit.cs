using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Ambacht.Common.Services
{
    public interface IAsyncInit
    {

        Task InitAsync(CancellationToken token);

    }

    public static class IServiceProviderExtensions
    {

        public static async Task InitAsync(this IServiceProvider serviceProvider, CancellationToken token)
        {
            foreach (var item in serviceProvider.GetServices<IAsyncInit>())
            {
                await item.InitAsync(token);
            }
        }

    }

}
