using Microsoft.EntityFrameworkCore;
using StarWars.Games.BackOffice.Web.UI.App_Code.CustomSettings;
using StarWars.Games.BackOffice.Web.UI.App_Code.MethodesExtensions;
using StarWars.Games.BackOffice.Web.UI.Areas.Identity.Data;
using StarWars.Games.BackOffice.Web.UI.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("CustomIdentityContextConnection") ?? throw new InvalidOperationException("Connection string 'CustomIdentityContextConnection' not found.");

builder.Services.AddDbContext<CustomIdentityContext>(options =>
	options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<CustomUser>(options =>
{
	options.SignIn.RequireConfirmedAccount = true;
})
	.AddEntityFrameworkStores<CustomIdentityContext>();

#region Injection de d�pendances / Param�trages
builder.Services.AddRazorPages();

builder.Services.AddHttpClient();

#region Options
// var maConfigRecherche = builder.Configuration["RechercheSetting:Longueur"]; // Si recherche direct depuis config

builder.Services.Configure<SearchSetting>(builder.Configuration.GetSection("RechercheSetting")); // injection de la class et donc de son instance dans tout le projet
#endregion

builder.Services.AddCustomInjectionDependances(builder.Configuration);

#region Sessions
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
	options.IdleTimeout = TimeSpan.FromMinutes(20);
});
#endregion
#endregion


var app = builder.Build();


#region Middleware
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) // IsEnvironment("VotreEnv")
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseAuthentication(); ;

app.UseAuthorization();


#endregion

#region Endpoints 
app.MapRazorPages();
#endregion

app.Run();
