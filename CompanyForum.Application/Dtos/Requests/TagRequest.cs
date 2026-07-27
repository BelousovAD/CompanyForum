namespace CompanyForum.Application.Dtos.Requests;

public record TagRequest(
    string Text) : IRequest;