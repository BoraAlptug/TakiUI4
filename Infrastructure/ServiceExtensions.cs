using System.Net.Http.Headers;
using TakiUI4.DataAccess;
using TakiUI4.Services;
using TakiUI4.Services.Interfaces;

namespace TakiUI4.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void ConfigureServiceManager(this IServiceCollection services)
        {
            #region Managers
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IDataAccessManager, DataAccessManager>();
            #endregion
            #region Services
            services.AddScoped<IMainDataAccess, MainDataAccess>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IUsersService, UsersService>();
            services.AddScoped<ISliderService, SliderService>();
            #endregion
        }
        public static void ConfigureHttpClient(this IServiceCollection services, IConfiguration configuration)
        {
            var BaseAddress = configuration["AppSettings:BaseConnection"];
            services.AddHttpClient<IMainDataAccess, MainDataAccess>(client =>
            {
                var BaseAddress = configuration["AppSettings:BaseConnection"];
                if (string.IsNullOrEmpty(BaseAddress))
                {
                    throw new ArgumentNullException("BaseAddress", "BaseAddress cannot be null or empty");
                }
                client.BaseAddress = new Uri(BaseAddress);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            });

        }
    }
}
