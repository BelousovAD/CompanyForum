namespace CompanyForum.Domain.Models;

public class Comment : BaseModel
{
    // public Comment(Branch branch, string text, Guid? id = null, User? user = null)
    //     : base(id)
    // {
    //     Branch = branch;
    //     User = user;
    //     Change(text);
    // }

    public string Text { get; private set; } = string.Empty;

    public User? User { get; }

    public Branch Branch { get; }

    public void Change(string text)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text, nameof(text));

        if (Text == text)
        {
            return;
        }

        Text = text;
    }
}