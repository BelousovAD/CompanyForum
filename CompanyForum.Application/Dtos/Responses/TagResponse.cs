namespace CompanyForum.Application.Dtos.Responses;

public record TagResponse(
    Guid Id,
    string Text) : IResponse;