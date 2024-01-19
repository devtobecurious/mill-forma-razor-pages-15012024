using FakeLoggerTest;
using Microsoft.EntityFrameworkCore;
using StarWars.BackOffice.Core.Models.Data;
using StarWars.BackOffice.Core.Services;
using StarWars.Games.Core.Interfaces;

namespace StarWars.Games.BackOffice.Web.UI.App_Code.MethodesExtensions
{
    public static class ServiceCollectionsExtensionMethods
    {
        #region Public methods
        public static IServiceCollection AddCustomInjectionDependances(this IServiceCollection services, IConfiguration configuration)
        {
            //TODO: 16/01/2024: Refacto => méthodes d'extension

            services.AddSingleton<ICustomLogger, TestLogger>();

            services.AddDbContext<DefaultDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("BackOffice.DB"),
                                     b => b.MigrationsAssembly("StarWars.Games.BackOffice.Web.UI"));
            });

            services.AddScoped<IVideoGameService, SqlServerDbContextVideoGameService>();
            services.AddScoped<IGameService, InMemoryGameService>();
            services.AddScoped<IStatisticService, StatisticService>();
            services.AddScoped<IAmiService, SqlServerDbContextAmiService>();
            // services.AddScoped<IPersonService, InMemoryPersonnageService>();
            services.AddScoped<IPersonService, HttpClientPersonnageService>();

            return services;
        }
        #endregion
    }
}
