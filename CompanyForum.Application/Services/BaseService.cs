using AutoMapper;
using CompanyForum.Application.Dtos.Requests;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Application.Interfaces;
using CompanyForum.Domain.Interfaces;

namespace CompanyForum.Application.Services;

public abstract class BaseService<TDomain, TRepository, TRequest, TResponse>(TRepository repository, IMapper mapper)
    : IService<TRequest, TResponse>
    where TDomain : class
    where TRepository : IRepository<TDomain>
    where TRequest : IRequest
    where TResponse : IResponse
{
    public async Task<IEnumerable<TResponse>> GetAll()
    {
        IEnumerable<TDomain> tags = await repository.GetAll();

        return tags.Select(mapper.Map<TResponse>);
    }

    public async Task<TResponse?> GetById(Guid id)
    {
        TDomain? model = await repository.GetById(id);

        return mapper.Map<TResponse>(model);
    }

    public async Task<Guid> Create(TRequest request)
    {
        TDomain model = mapper.Map<TDomain>(request);
        
        return await repository.Create(model);
    }

    public async Task<Guid> Delete(Guid id) =>
        await repository.Delete(id);
}