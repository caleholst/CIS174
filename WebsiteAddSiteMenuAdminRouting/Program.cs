var builder = WebApplication.CreateBuilder(args);

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



app.MapAreaControllerRoute( 
    name: "admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

// this one will never show up because I just used id for the custom attribute, but if I didn't this one would go above the first
// because it would have more specfic things it is looking for. 
app.MapAreaControllerRoute(
    name: "customAttribute",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Attribute}/{id?}");

// this counts as the default routing right? 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
