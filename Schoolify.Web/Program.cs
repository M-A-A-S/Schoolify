using Microsoft.AspNetCore.Localization;
using System.Globalization;
using Schoolify.Business;
using Schoolify.Common;
using Microsoft.Extensions.Localization;

var builder = WebApplication.CreateBuilder(args);


//builder.Services.AddLocalization(options =>
//{
//    options.ResourcesPath = "Resources";
//});

//builder.Services.AddLocalization();

builder.Services.AddLocalization(options =>
{
    options.ResourcesPath = "Resources";
});

builder.Services.AddControllersWithViews()
    .AddViewLocalization()
    .AddDataAnnotationsLocalization();



// Add services to the container.
//builder.Services.AddControllersWithViews();

builder.Services.AddBusinessServices(builder.Configuration);

//AppSettings.ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");


var app = builder.Build();

var supportedCultures = new[]
{
    new CultureInfo("en"),
    new CultureInfo("ar")
};

var localizationOptions = new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("en"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures,

    //RequestCultureProviders = new IRequestCultureProvider[]
    //{
    //    new CookieRequestCultureProvider(),
    //    new QueryStringRequestCultureProvider(),
    //    new AcceptLanguageHeaderRequestCultureProvider()
    //}
};

// Remove browser/cookie providers so Arabic is always the default
//localizationOptions.RequestCultureProviders.Clear();

localizationOptions.RequestCultureProviders = new IRequestCultureProvider[]
{
    new CookieRequestCultureProvider()
};

// Optional: force thread culture
//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("ar");
//CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("ar");

app.UseRequestLocalization(localizationOptions);

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
