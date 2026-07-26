using CompanyForum.Domain.Interfaces;
using CompanyForum.Domain.Models;

namespace CompanyForum.Infrastructure.Repositories;

public class TagRepository(CompanyForumDbContext context)
    : BaseRepository<Tag>(context), ITagRepository;