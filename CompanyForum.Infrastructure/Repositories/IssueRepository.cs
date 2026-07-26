using CompanyForum.Domain.Interfaces;
using CompanyForum.Domain.Models;

namespace CompanyForum.Infrastructure.Repositories;

public class IssueRepository(CompanyForumDbContext context)
    : BaseRepository<Issue>(context), IIssueRepository;