using CompanyForum.Api.Endpoints;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Application.Interfaces;

namespace CompanyForum.Api.Issues;

internal class GetAllEndpoint : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder builder)
    {
        builder.MapGet("/issues", Handle);
    }

    private static async Task<IResult> Handle(IIssueService service)
    {
        IEnumerable<IssueResponse> branches = await service.GetAll();

        return Results.Ok(branches);
    }
}