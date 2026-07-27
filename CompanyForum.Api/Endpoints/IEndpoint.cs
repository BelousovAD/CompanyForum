namespace CompanyForum.Api.Endpoints;

internal interface IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder builder);
}