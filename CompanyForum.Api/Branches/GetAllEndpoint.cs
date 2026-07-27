using CompanyForum.Api.Endpoints;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Application.Interfaces;

namespace CompanyForum.Api.Branches;

internal class GetAllEndpoint : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder builder)
    {
        builder.MapGet("/branches", Handle);
    }

    private static async Task<IResult> Handle(IBranchService service)
    {
        IEnumerable<BranchResponse> branches = await service.GetAll();

        return Results.Ok(branches);
    }
}