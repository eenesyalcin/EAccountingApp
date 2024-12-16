using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Companies.DeleteCompanyById;

public sealed record DeleteCompanyByIdCommand(
    Guid Id) : IRequest<Result<string>>;
