using Factory_Shop.Data;
using Factory_Shop.Data.Interfaces;
using Factory_Shop.Data.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string conection = builder.Configuration.GetConnectionString("DefaultConnection");


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IMaterials, MatRepository>();
builder.Services.AddTransient<IMatCategory, CategoryRepository>();
builder.Services.AddDbContext<AddDBContend>(options => options.UseSqlServer(conection));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.MapGet("/", (AddDBContend contend) => contend.Materials.ToList());
//app.MapGet("/", (AddDBContend contend) => contend.Category.ToList());

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

using (var scope = app.Services.CreateScope())
{
    AddDBContend contend = scope.ServiceProvider.GetRequiredService<AddDBContend>();
    DBObjects.Initial(contend);
}

app.Run();




