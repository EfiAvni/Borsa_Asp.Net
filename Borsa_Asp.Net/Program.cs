var builder = WebApplication.CreateBuilder(args);

// HttpClient ekleme
builder.Services.AddHttpClient();

// Diðer servisleri ekliyoruz
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
