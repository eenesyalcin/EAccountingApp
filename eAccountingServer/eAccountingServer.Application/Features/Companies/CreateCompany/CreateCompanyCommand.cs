using eAccountingServer.Domain.ValueObjects;
using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Companies.CreateCompany;

public sealed record CreateCompanyCommand(
    string Name,
    string FullAddress,
    string TaxDepartment,
    string TaxNumber,
    Database Database) : IRequest<Result<string>>;
