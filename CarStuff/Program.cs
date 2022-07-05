using CarStuff.DAL;
using CarStuff.DAL.Repositories;
using CarStuff.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// register context
builder.Services.AddDbContext<CarContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CarContext")));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// register repos
builder.Services.AddScoped<IAddressRepo,AddressRepo>();
builder.Services.AddScoped<ICarPurchaseRepo,CarPurchaseRepo>();
builder.Services.AddScoped<ICarRepo,CarRepo>();
builder.Services.AddScoped<ICustomerRepo,CustomerRepo>();
builder.Services.AddScoped<IExtraItemRepo,ExtraItemRepo>();
builder.Services.AddScoped<ISalesPersonRepo,SalesPersonRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}

// create db
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<CarContext>();
    context.Database.EnsureCreated();
    new DbInitializer(context).Initialize();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
