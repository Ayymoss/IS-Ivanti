using System.Reflection;
using System.Text.Json;
using ISIvanti.Server.Interfaces;
using ISIvanti.Server.Services;
using ISIvanti.Server.Utilities;
using Microsoft.AspNetCore.Authentication.Cookies;

var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
var file = File.ReadAllText(Path.Join(directory, "_Configuration.json"));
var configuration = JsonSerializer.Deserialize<Configuration>(file);
if (configuration is null) return;

var builder = WebApplication.CreateBuilder(args);

//if (configuration.CertificatePath is not null && configuration.CertificatePassword is not null)
//{
//    Console.WriteLine("Starting as HTTPS with Certification");
//    builder.WebHost.UseKestrel(options =>
//    {
//        options.ListenAnyIP(8122);
//        options.ListenAnyIP(8123, configure => configure.UseHttps(configuration.CertificatePath, configuration.CertificatePassword));
//    });
//}
//else
{
    builder.WebHost.ConfigureKestrel(options =>
    {
#if !DEBUG
        Console.WriteLine("Starting as HTTPS without Certification");  
        options.ListenAnyIP(8122);
        options.ListenAnyIP(8123, configure => configure.UseHttps());
#else
        Console.WriteLine("Starting as HTTPS as Local");
        options.ListenLocalhost(8122);
        options.ListenLocalhost(8123, configure => configure.UseHttps());
#endif
    });
}

// Add services to the container.

builder.Services.AddLogging();
builder.Services.AddSignalR();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSwaggerGen();

builder.Logging.ClearProviders().AddConsole();

// Singletons
builder.Services.AddSingleton(configuration);
builder.Services.AddSingleton<StringEncryption>();

// Scoped
builder.Services.AddScoped<ApiClient>();
builder.Services.AddScoped<IIvantiDatabaseService, IvantiDatabaseService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddSingleton<UserManager>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(opt =>
    {
        opt.Cookie.Name = "BanHubAccount";
#if DEBUG
        opt.LogoutPath = "/";
        opt.LoginPath = "/";
#else
        opt.LogoutPath = "/";
        opt.LoginPath = "/";
#endif
    });
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsSpecs", corsPolicyBuilder =>
    {
        corsPolicyBuilder
            .AllowAnyHeader()
            .AllowAnyMethod()
            .SetIsOriginAllowed(_ => true)
            .AllowCredentials();
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseCors("CorsSpecs");
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
