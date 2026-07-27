using CompanyForum.Api.Endpoints;
using CompanyForum.Application;
using CompanyForum.Application.Interfaces;
using CompanyForum.Application.Services;
// using CompanyForum.Application.Services;
using CompanyForum.Domain.Interfaces;
using CompanyForum.Infrastructure;
using CompanyForum.Infrastructure.Repositories;
using Microsoft.OpenApi;
using Serilog;
using Serilog.Exceptions;

namespace CompanyForum.Api.Configuration;

internal static class Installer
{
    public static IServiceCollection AddConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSerilogLogging(configuration);
        services.AddOpenApiSpec();
        services.AddEndpoints(typeof(Program).Assembly);
        services.AddInfrastructure();
        services.AddApplication();

        return services;
    }

    private static IServiceCollection AddOpenApiSpec(this IServiceCollection services)
    {
        services.AddOpenApi();
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Education Content Service",
                Version = "1.0.0",
                Contact = new OpenApiContact
                {
                    Name = "Belousov A.D.",
                    Email = "lx.belousov@mail.ru"
                }
            });
        });

        return services;
    }

    private static IServiceCollection AddSerilogLogging(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSerilog((serviceProvider, loggerConfiguration) => loggerConfiguration
            .ReadFrom.Configuration(configuration)
            .ReadFrom.Services(serviceProvider)
            .Enrich.FromLogContext()
            .Enrich.WithExceptionDetails());

        return services;
    }
    
    private static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<CompanyForumDbContext>();
        services.AddScoped<IBranchRepository, BranchRepository>();
        services.AddScoped<ICommentRepository, CommentRepository>();
        services.AddScoped<IIssueRepository, IssueRepository>();
        services.AddScoped<ITagRepository, TagRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        
        return services;
    }

    private static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ApplicationAssemblyTag).Assembly);
        services.AddScoped<IBranchService, BranchService>();
        services.AddScoped<ICommentService, CommentService>();
        services.AddScoped<IIssueService, IssueService>();
        services.AddScoped<ITagService, TagService>();
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}