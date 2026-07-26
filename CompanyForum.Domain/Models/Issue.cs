namespace CompanyForum.Domain.Models;

public class Issue : BaseModel
{
    private readonly SortedSet<Tag> _tags = [];

    // public Issue(string title,
    //     string description,
    //     Guid? id = null,
    //     User? user = null,
    //     IssueStatus status = IssueStatus.Created,
    //     IEnumerable<Tag>? tags = null)
    //     : base(id)
    // {
    //     User = user;
    //     Change(title, description);
    //     Status = status;
    //
    //     if (tags is not null)
    //     {
    //         _tags.UnionWith(tags);
    //     }
    // }
    
    public User? User { get; }

    public string Title { get; private set; } = string.Empty;

    public string Description { get; private set; } = string.Empty;

    public IssueStatus Status { get; private set; }
    
    public IReadOnlySet<Tag> Tags => _tags;

    public void Change(string title, string description)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(title, nameof(title));
        ArgumentException.ThrowIfNullOrWhiteSpace(description, nameof(description));

        if (Title != title)
        {
            Title = title;
        }

        if (Description != description)
        {
            Description = description;
        }
    }

    public void NextStatus()
    {
        IssueStatus[] statusValues = Enum.GetValues<IssueStatus>();
        Status = statusValues[((int)Status + 1) % statusValues.Length];
    }
}