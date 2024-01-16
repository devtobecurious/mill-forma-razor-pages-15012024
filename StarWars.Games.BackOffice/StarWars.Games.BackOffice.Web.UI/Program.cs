using FakeLoggerTest;
using Microsoft.EntityFrameworkCore;
using StarWars.BackOffice.Core.Models.Data;
using StarWars.BackOffice.Core.Services;
using StarWars.Games.Core.Interfaces;

var builder = WebApplication.CreateBuilder(args);

#region Injection de dépendances / Paramétrages
builder.Services.AddRazorPages();

//TODO: 16/01/2024: Refacto => méthodes d'extension
#if DEBUG
builder.Services.AddSingleton<ICustomLogger, TestLogger>();
#else
builder.Services.AddSingleton<ICustomLogger, FileCustomLogger>();
#endif

builder.Services.AddDbContext<DefaultDbContext>(options =>
{
	options.UseSqlServer("Server=DESKTOP-1446PBQ;Database=StarWars.BackOffice.Db.DEV;Trusted_Connection=True;TrustServerCertificate=true");
});

builder.Services.AddScoped<IVideoGameService, SqlServerDbContextVideoGameService>();
builder.Services.AddScoped<IGameService, InMemoryGameService>();
builder.Services.AddScoped<IStatisticService, StatisticService>();
#endregion

var app = builder.Build();


#region Middleware
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
#endregion

#region Endpoints 
app.MapRazorPages();
#endregion

app.Run();
