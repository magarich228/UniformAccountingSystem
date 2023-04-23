using Microsoft.EntityFrameworkCore;
using UniformAccountingSystem.Data;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
var services = builder.Services;

services.AddDbContext<UniformAccountingContext>(options => options.UseSqlServer(configuration.GetConnectionString("uas")));

services.AddUasBLLServices();

services.AddRazorPages();
services.AddServerSideBlazor();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
