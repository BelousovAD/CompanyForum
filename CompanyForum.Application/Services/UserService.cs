using AutoMapper;
using CompanyForum.Application.Dtos.Requests;
using CompanyForum.Application.Dtos.Responses;
using CompanyForum.Application.Interfaces;
using CompanyForum.Domain.Interfaces;
using CompanyForum.Domain.Models;

namespace CompanyForum.Application.Services;

public class UserService(IUserRepository repository, IMapper mapper)
    : BaseService<User, IUserRepository, UserRequest, UserResponse>(repository, mapper), IUserService;