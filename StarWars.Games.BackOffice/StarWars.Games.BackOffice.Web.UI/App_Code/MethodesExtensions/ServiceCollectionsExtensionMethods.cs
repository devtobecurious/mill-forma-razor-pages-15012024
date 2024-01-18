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
		public static IServiceCollection AddCustomInjectionDependances(this IServiceCollection services)
		{
			//TODO: 16/01/2024: Refacto => méthodes d'extension
#if DEBUG
			services.AddSingleton<ICustomLogger, TestLogger>();
#else
			services.AddSingleton<ICustomLogger, FileCustomLogger>();
#endif

			services.AddDbContext<DefaultDbContext>(options =>
			{
				options.UseSqlServer("Server=DESKTOP-1446PBQ;Database=StarWars.BackOffice.Db.DEV;Trusted_Connection=True;TrustServerCertificate=true");
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
