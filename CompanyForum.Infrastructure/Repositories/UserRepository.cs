using CompanyForum.Domain.Interfaces;
using CompanyForum.Domain.Models;

namespace CompanyForum.Infrastructure.Repositories;

public class UserRepository(CompanyForumDbContext context)
    : BaseRepository<User>(context), IUserRepository;