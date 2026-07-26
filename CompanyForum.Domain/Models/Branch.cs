namespace CompanyForum.Domain.Models;

public class Branch : BaseModel
{
    // public Branch(Issue issue,  Guid? id = null, User? user = null, bool isSolution = false) : base(id)
    // {
    //     Issue = issue;
    //     User = user;
    //     IsSolution = isSolution;
    // }

    public Issue Issue { get; }

    public User? User { get; }

    public bool IsSolution { get; private set; }

    public void MarkAsSolution() =>
        IsSolution = true;
}