using CompanyForum.Api.Endpoints;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Application.Interfaces;

namespace CompanyForum.Api.Tags;

internal class GetAllEndpoint : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder builder)
    {
        builder.MapGet("/tags", Handle);
    }

    private static async Task<IResult> Handle(ITagService service)
    {
        IEnumerable<TagResponse> tags = await service.GetAll();

        return Results.Ok(tags);
    }
}