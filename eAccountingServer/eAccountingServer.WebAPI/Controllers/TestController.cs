using eAccountingServer.WebAPI.Abstractions;
using FluentEmail.Core;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eAccountingServer.WebAPI.Controllers;

[AllowAnonymous]
public sealed class TestController : ApiController
{
    private readonly IFluentEmail _fluentEmail;
    public TestController(IMediator mediator, IFluentEmail fluentEmail) : base(mediator)
    {
        _fluentEmail = fluentEmail;
    }

    [HttpGet]
    public async Task<IActionResult> SendTestEmail()
    {
        await _fluentEmail
            .To("enesyalcin@gmail.com")
            .Subject("Test Maili")
            .Body("<h1>Mail gönderme testi</h1>", true)
            .SendAsync();

        return NoContent();
    }
}