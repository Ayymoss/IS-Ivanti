using System.Reflection;
using System.Text.Json;
using ISIvanti.Server.Context;
using ISIvanti.Server.Interfaces;
using ISIvanti.Server.Services;
using ISIvanti.Server.Services.Pages;
using ISIvanti.Server.Services.Sentinel;
using ISIvanti.Server.Utilities;
using ISIvanti.Shared.Utilities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Serilog;

var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
var file = File.ReadAllText(Path.Join(directory, "Configuration", "_Configuration.json"));
var configuration = JsonSerializer.Deserialize<Configuration>(file);
if (configuration is null) return;

var builder = WebApplication.CreateBuilder(args);

if (configuration.CertificatePath is not null && configuration.CertificatePassword is not null)
{
    Console.WriteLine("Starting as HTTPS with Custom Certification");
    builder.WebHost.UseKestrel(options =>
    {
        options.ListenAnyIP(8123, configure =>
            configure.UseHttps(configuration.CertificatePath, configuration.CertificatePassword));
    });
}
else
{
    builder.WebHost.ConfigureKestrel(options =>
    {
#if !DEBUG
        Console.WriteLine("Starting as HTTPS with Developer Certificate");  
        options.ListenAnyIP(8122);
        options.ListenAnyIP(8123, configure => configure.UseHttps());
#else
        Console.WriteLine("Starting as HTTPS as Local Certificate");
        options.ListenLocalhost(8122);
        options.ListenLocalhost(8123, configure => configure.UseHttps());
#endif
    });
}

#if DEBUG
builder.Services.AddDbContext<LocalDataContext>(options => options.UseSqlite($"Data Source=_Database.db"));
#else
builder.Services.AddDbContext<LocalDataContext>(options => options.UseSqlite($"Data Source={configuration.LocalDatabaseLocation}"));
#endif
builder.Services.AddDbContext<IvantiDataContext>(options =>
    options.UseSqlServer(configuration.IvantiDatabaseConnectionString));
builder.Services.AddHostedService<BackgroundTaskService>();
builder.Services.AddHostedService<StatisticsGatheringService>();

// Singletons
builder.Services.AddSingleton(configuration);
builder.Services.AddSingleton<UserManager>();
builder.Services.AddSingleton<IBackgroundTaskQueue, BackgroundTaskQueue>();
builder.Services.AddSingleton<ISystemService, SystemService>();
builder.Services.AddSingleton<ISentinelService, SentinelService>();
builder.Services.AddSingleton<SentinelApi>();

// Scoped
builder.Services.AddScoped<ApiClient>();
builder.Services.AddScoped<JobBackgroundTask>();
builder.Services.AddScoped<IAgentService, AgentService>();
builder.Services.AddScoped<IAuthService, AuthService>();

if (!Directory.Exists(Path.Join(AppContext.BaseDirectory, "Log")))
    Directory.CreateDirectory(Path.Join(AppContext.BaseDirectory, "Log"));

var logLevel = configuration.LogLevel.StringToLogLevel();

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .MinimumLevel.Override("Microsoft", logLevel)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.File(
        Path.Join(AppContext.BaseDirectory, "Log", "patch-.log"),
        rollingInterval: RollingInterval.Day,
        retainedFileCountLimit: 10,
        outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff}] [{Level:u3}] {Message:lj}{NewLine}{Exception}")
    .CreateLogger();

// Add services to the container.
builder.Services.AddSignalR();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(opt =>
    {
        opt.Cookie.Name = "ISIAccount";
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

// Host Level Meta
builder.Host.UseSerilog();
builder.Host.UseWindowsService();

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
