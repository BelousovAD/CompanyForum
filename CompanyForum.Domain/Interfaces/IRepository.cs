namespace CompanyForum.Domain.Interfaces;

public interface IRepository<T>
    where T : class
{
    public Task<IEnumerable<T>> GetAll();

    public Task<T?> GetById(Guid id);

    public Task<Guid> Create(T model);

    public Task<Guid> Delete(Guid id);

    public Task<int> Save();
}