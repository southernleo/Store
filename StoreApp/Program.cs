using StoreApp.Infrastructure.Extensions;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.ConfigureDbContedxt(builder.Configuration);
builder.Services.ConfigureIdentity();
builder.Services.ConfigureSession();

builder.Services.ConfigureRepositoryRegistration();
builder.Services.ConfigureServiceRegistration();
builder.Services.ConfigureRouting();


builder.Services.AddAutoMapper(typeof(Program));


var app = builder.Build();


app.UseStaticFiles();
app.UseSession();
app.UseHttpsRedirection();
app.UseRouting();
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
});
app.ConfigureAndCheckMigration();
app.ConfigureLocalization();
app.ConfigureDefaultAdminUser();
app.Run();