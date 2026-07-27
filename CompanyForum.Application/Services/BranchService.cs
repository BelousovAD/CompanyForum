using AutoMapper;
using CompanyForum.Application.Dtos.Requests;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Application.Interfaces;
using CompanyForum.Domain.Interfaces;
using CompanyForum.Domain.Models;

namespace CompanyForum.Application.Services;

public class BranchService(IBranchRepository repository, IMapper mapper)
    : BaseService<Branch, IBranchRepository, BranchRequest, BranchResponse>(repository, mapper), IBranchService;