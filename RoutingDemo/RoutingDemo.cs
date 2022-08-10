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

//** InBuild Code**//

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");


#region Conventional Routing
// Conventional Attribute either we use both below method or we use single


//app.UseEndpoints(endpoints => {
//    endpoints.MapControllerRoute
//(
//name: "default",
//pattern: "{controller=Home}/{action=Index}/{id?}");



//endpoints.MapControllerRoute
//(
//name: "default",
//pattern: "{controller=Product}/{action=Index}");

#endregion

#region Attribute Routing

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

#endregion

app.Run();
