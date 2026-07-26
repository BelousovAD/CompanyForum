using CompanyForum.Domain.Interfaces;
using CompanyForum.Domain.Models;

namespace CompanyForum.Infrastructure.Repositories;

public class CommentRepository(CompanyForumDbContext context)
    : BaseRepository<Comment>(context), ICommentRepository;