using eAccountingServer.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace eAccountingServer.Domain.Events;

public sealed class SendConfirmEmail(
    UserManager<AppUser> userManager) : INotificationHandler<AppUserEvent>
{
    public async Task Handle(AppUserEvent notification, CancellationToken cancellationToken)
    {
        AppUser? appUser = await userManager.FindByIdAsync(notification.UserId.ToString());
        if (appUser is not null)
        {
            // Onay Maili Gönder.
        }
    }
}
