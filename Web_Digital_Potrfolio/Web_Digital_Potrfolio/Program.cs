using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Web_Digital_Potrfolio.Data;
using Web_Digital_Potrfolio.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddDbContext<DigitalPortfolioContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DigitalPortfolioConnection"));
});
builder.Services.AddIdentity<User, IdentityRole<long>>().AddEntityFrameworkStores<DigitalPortfolioContext>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler();
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();