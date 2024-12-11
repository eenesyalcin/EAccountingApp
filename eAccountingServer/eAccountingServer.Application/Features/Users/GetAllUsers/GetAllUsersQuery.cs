using eAccountingServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Users.GetAllUsers;

public sealed record GetAllUsersQuery() : IRequest<Result<List<AppUser>>>;
