using CompanyForum.Domain.Interfaces;
using CompanyForum.Domain.Models;

namespace CompanyForum.Infrastructure.Repositories;

public class BranchRepository(CompanyForumDbContext context)
    : BaseRepository<Branch>(context), IBranchRepository;