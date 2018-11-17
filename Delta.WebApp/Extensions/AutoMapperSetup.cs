using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Delta.WebApp.Extensions
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper();
        }
    }
}