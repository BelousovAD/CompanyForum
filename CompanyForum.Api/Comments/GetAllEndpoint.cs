using CompanyForum.Api.Endpoints;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Application.Interfaces;

namespace CompanyForum.Api.Comments;

internal class GetAllEndpoint : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder builder)
    {
        builder.MapGet("/comments", Handle);
    }

    private static async Task<IResult> Handle(ICommentService service)
    {
        IEnumerable<CommentResponse> branches = await service.GetAll();

        return Results.Ok(branches);
    }
}