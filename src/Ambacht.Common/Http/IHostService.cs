using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambacht.Common.Http
{
    public interface IHostService
    {

        /// <summary>
        /// Returns the host, this app is running on, without the trailing slash
        /// </summary>
        /// <returns></returns>
        string GetHost();

    }

    public class HostService : IHostService
    {

        public HostService(string host)
        {
            if (host.EndsWith("/"))
            {
                host = host.Substring(0, host.Length - 1);
            }
            _host = host;
        }

        private readonly string _host;

        public string GetHost()
        {
            return _host;
        }
    }
}
