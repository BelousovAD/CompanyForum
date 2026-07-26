using CompanyForum.Domain.Interfaces;
using CompanyForum.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyForum.Infrastructure.Repositories;

public abstract class BaseRepository<T>(CompanyForumDbContext context) : IRepository<T>
    where T : BaseModel
{
    public async Task<IEnumerable<T>> GetAll() =>
        await context.Set<T>().AsNoTracking().ToListAsync();

    public async Task<T?> GetById(Guid id) =>
        await context.Set<T>().FindAsync(id);

    public async Task<Guid> Create(T model)
    {
        await context.Set<T>().AddAsync(model);
        await Save();

        return model.Id;
    }

    public async Task<Guid> Delete(Guid id)
    {
        await context.Set<T>()
            .Where(entity => entity.Id == id)
            .ExecuteDeleteAsync();

        return id;
    }

    public async Task<int> Save() =>
        await context.SaveChangesAsync();
}