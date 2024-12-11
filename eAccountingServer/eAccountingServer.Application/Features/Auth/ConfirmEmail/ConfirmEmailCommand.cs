using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Auth.ConfirmEmail;

public sealed record ConfirmEmailCommand(
    string Email) : IRequest<Result<string>>;
