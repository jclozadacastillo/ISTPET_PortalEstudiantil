using ISTPET_PortalEstudiantil.Auth;
using ISTPET_PortalEstudiantil.Models.sigafi_es;
using ISTPET_PortalEstudiantil.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);
Tools.Initialize(builder.Configuration, builder.Environment.WebRootPath);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.TryAddScoped<ISessionAlumnos, SessionAlumnos>();

builder.Services.AddDbContext<sigafi_esContext>(op => op.UseMySQL(builder.Configuration.GetConnectionString("sigafi_es")));
builder.Services.AddSession(options =>
{
    double diasJson = Convert.ToDouble(builder.Configuration["Sistema:timeOutSesionDays"]);
    options.IdleTimeout = TimeSpan.FromDays(diasJson);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Sistema}/{action=Index}/{id?}");

app.Run();
