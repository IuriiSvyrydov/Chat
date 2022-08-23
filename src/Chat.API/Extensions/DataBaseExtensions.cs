namespace Chat.API.Extensions;

    public static class DataBaseExtensions
    {
        public static IServiceCollection AddDbConnection(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ChatDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            return services;
        }
    }

