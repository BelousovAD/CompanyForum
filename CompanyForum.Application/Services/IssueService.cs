using AutoMapper;
using CompanyForum.Application.Dtos.Requests;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Application.Interfaces;
using CompanyForum.Domain.Interfaces;
using CompanyForum.Domain.Models;

namespace CompanyForum.Application.Services;

public class IssueService(IIssueRepository repository, IMapper mapper)
    : BaseService<Issue, IIssueRepository, IssueRequest, IssueResponse>(repository, mapper), IIssueService;