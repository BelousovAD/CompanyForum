using CompanyForum.Api.Endpoints;
using Serilog;

namespace CompanyForum.Api.Configuration;

internal static class AppExtensions
{
    public static IApplicationBuilder Configure(this WebApplication app)
    {
        app.UseSerilogRequestLogging();
        
        app.UseSwagger();
        app.UseSwaggerUI();

        RouteGroupBuilder apiGroup = app.MapGroup("/api");
        app.MapEndpoints(apiGroup);

        return app;
    }
}