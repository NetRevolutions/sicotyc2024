using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using NLog;
using sicotyc.contracts;
using sicotyc.Server.Extensions;

var builder = WebApplication.CreateBuilder(args);

LogManager.Setup().LoadConfigurationFromFile(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Add services to the container.
builder.Services.ConfigureCORS();
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureSearchService();
builder.Services.ConfigureUploadFileService();
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});
builder.Services.ConfigureValidationFilterAttribute();
builder.Services.ConfigureValidationTokenFilter();

//builder.Services.AddControllers(); // Por defecto solo devuelve en text/json

// Hacer que devuelve en otros formatos
builder.Services.AddControllers(config => {
    config.RespectBrowserAcceptHeader = true; // Con esto habilito otros tipos de respuestas (ej. text/xml) 
    config.ReturnHttpNotAcceptable = true; // Con esto retrinjo respuestas aceptables (ej: text/json, text/xml
    //config.CacheProfiles.Add("120SecondsDuration", new CacheProfile { Duration = 120});
}).AddXmlDataContractSerializerFormatters(); // Serializo en XML

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMemoryCache();
builder.Services.ConfigureRateLimitingOptions();
builder.Services.AddHttpContextAccessor();

builder.Services.AddAuthentication();
builder.Services.ConfigureIdentity();
builder.Services.ConfigureJWT(builder.Configuration);
builder.Services.ConfigureSwagger();
builder.Services.AddFluentEmail(builder.Configuration);
builder.Services.AddHttpClient();

var app = builder.Build();

var logger = app.Services.GetRequiredService<ILoggerManager>();
app.ConfigureExceptionHandler(logger);

app.UseHttpsRedirection();
// Usado para soportar archivos staticos dentro del wwwroot
app.Use(async (context, next) => { 
    await next();
    if (context.Response.StatusCode == 404 && !System.IO.Path.HasExtension(context.Request.Path.Value))
    {
        context.Request.Path = "/index.html";
        await next();
    }
});

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else {   

    // TODO: Cuando este mas maduro el proyecto comentar esta parte
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseCors("CorsPolicy");


app.UseAuthentication();
//app.UseIpRateLimiting();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    // Configurar las rutas para la API
    endpoints.MapControllers();

    endpoints.MapControllerRoute(
        name: "api",
        pattern: "api/{controller}/{action=Index}/{id?}"
    );
    
    //endpoints.MapFallbackToFile("/index.html");
});

app.MapControllers();
//app.MapFallbackToFile("/index.html");

app.Run();
