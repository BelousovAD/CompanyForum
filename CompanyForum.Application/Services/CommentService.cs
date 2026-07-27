using AutoMapper;
using CompanyForum.Application.Dtos.Requests;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Application.Interfaces;
using CompanyForum.Domain.Interfaces;
using CompanyForum.Domain.Models;

namespace CompanyForum.Application.Services;

public class CommentService(ICommentRepository repository, IMapper mapper)
    : BaseService<Comment, ICommentRepository, CommentRequest, CommentResponse>(repository, mapper), ICommentService;