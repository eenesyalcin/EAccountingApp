using MediatR;
using TS.Result;

namespace eAccountingServer.Application.Features.Auth.SendConfirmEmail;

public sealed record SendConfirmEmailCommand(
    string Email) : IRequest<Result<string>>;
