using StoreApp.Infrastructure.Extensions;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddControllersWithViews().
AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly);
builder.Services.AddRazorPages();
builder.Services.ConfigureDbContedxt(builder.Configuration);
builder.Services.ConfigureIdentity();
builder.Services.ConfigureSession();

builder.Services.ConfigureRepositoryRegistration();
builder.Services.ConfigureServiceRegistration();
builder.Services.ConfigureRouting();
builder.Services.ConfigureApplicationCookie();


builder.Services.AddAutoMapper(typeof(Program));


var app = builder.Build();


app.UseStaticFiles();
app.UseSession();
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
    );

    _ = endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}"
    );
    _ = endpoints.MapRazorPages();
    _= endpoints.MapControllers();
});

app.ConfigureAndCheckMigration();
app.ConfigureLocalization();
app.ConfigureDefaultAdminUser();
app.Run();