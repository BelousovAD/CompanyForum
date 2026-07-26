namespace CompanyForum.Domain.Models;

public class User : BaseModel
{
    private readonly SortedSet<Tag> _tags = [];

    // public User(Role role, Guid? id = null, IEnumerable<Tag>? tags = null)
    //     : base(id) =>
    //     Change(role, tags);

    public Role Role { get; private set; }

    public IReadOnlySet<Tag> Tags => _tags;

    public void Change(Role role, IEnumerable<Tag>? tags)
    {
        Role = role;

        if (tags is not null)
        {
            _tags.UnionWith(tags);
        }
    }
}