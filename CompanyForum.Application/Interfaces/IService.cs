using CompanyForum.Application.Dtos.Requests;
using CompanyForum.Application.Dtos.Responses;

namespace CompanyForum.Application.Interfaces;

public interface IService<in TRequest, TResponse>
    where TRequest : IRequest
    where TResponse : IResponse
{
    public Task<IEnumerable<TResponse>> GetAll();

    public Task<TResponse?> GetById(Guid id);

    public Task<Guid> Create(TRequest request);

    public Task<Guid> Delete(Guid id);
}