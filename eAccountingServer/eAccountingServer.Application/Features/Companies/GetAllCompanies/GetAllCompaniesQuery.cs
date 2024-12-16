using eAccountingServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Companies.GetAllCompanies;

public sealed record GetAllCompaniesQuery() : IRequest<Result<List<Company>>>;
