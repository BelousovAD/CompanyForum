namespace CompanyForum.Domain.Models;

public class Tag : BaseModel
{
    // public Tag(string text, Guid? id = null)
    //     : base(id) =>
    //     Change(text);

    public string Text { get; private set; } = string.Empty;

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