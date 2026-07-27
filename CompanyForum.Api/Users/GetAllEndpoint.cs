using CompanyForum.Api.Endpoints;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Application.Interfaces;

namespace CompanyForum.Api.Users;

internal class GetAllEndpoint : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder builder)
    {
        builder.MapGet("/branches", Handle);
    }

    private static async Task<IResult> Handle(IUserService service)
    {
        IEnumerable<UserResponse> branches = await service.GetAll();

        return Results.Ok(branches);
    }
}