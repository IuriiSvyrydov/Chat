
using System.Reflection;

namespace Chat.API.Extensions;

    public  static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationExtensions(this IServiceCollection services)
        {
            services.AddMediatR(typeof(Program),typeof(GetUsersCommand));
            services.AddAutoMapper(typeof(Program),typeof(GetUsersCommand));
            return services;
        }
    }

