using Loggers;

var builder = WebApplication.CreateBuilder(args);

// Services ko add karein (agar required ho toh)
// builder.Services.AddControllers(); // Example: AddControllers

var app = builder.Build();

// Custom Middleware ko pipeline me add karein
app.UseMiddleware<LoggingMiddleware>();

// Baaki middlewares
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // Ensure controllers are added in services
});

app.Run();
