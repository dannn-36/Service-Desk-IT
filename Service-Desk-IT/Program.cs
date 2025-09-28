using Microsoft.EntityFrameworkCore;
//using Service_Desk_IT.Data;


var builder = WebApplication.CreateBuilder(args);


//coneccion con EF
//builder.Services.AddDbContext<ServiceDeskContext>(options =>
  //  options.UseMySql(builder.Configuration.GetConnectionString("ServiceDeskDB"),
    //    new MySqlServerVersion(new Version(8, 0, 41)))); 



// Add services to the container.
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
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
