namespace CompanyForum.Domain.Models;

public abstract class BaseModel
{
    protected BaseModel() =>
        Id = Guid.NewGuid();

    protected BaseModel(Guid id) =>
        Id = id;

    public Guid Id { get; }
}