using StarWars.Games.BackOffice.Web.UI.App_Code.MethodesExtensions;

var builder = WebApplication.CreateBuilder(args);

#region Injection de dépendances / Paramétrages
builder.Services.AddRazorPages();

builder.Services.AddHttpClient();

builder.Services.AddCustomInjectionDependances(builder.Configuration);
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
