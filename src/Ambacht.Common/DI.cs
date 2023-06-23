﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Ambacht.Common.Http;
using Ambacht.Common.Services;

namespace Ambacht.Common
{
    public static class DI
    {

        public static void AddAmbachtCommon(this IServiceCollection services)
        {
            services.AddScoped<INowService, NowService>();
            services.AddTransient<IIdGenerator, IdGenerator>();
        }

    }
}
