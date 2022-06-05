using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CreatePDF.Data.Appcont>
    (options => options.UseMySql(
        "server=localhost;initial catalog=CRUD_PDF;uid=root;pwd=@Lcs200212",
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql")));

builder.Services.AddControllersWithViews();

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Suppliers}/{action=Index}/{id?}");

app.Run();
