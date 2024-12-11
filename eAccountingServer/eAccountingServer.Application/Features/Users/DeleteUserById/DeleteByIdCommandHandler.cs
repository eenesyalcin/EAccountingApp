using eAccountingServer.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using TS.Result;

namespace eAccountingServer.Application.Features.Users.DeleteUserById;

internal sealed class DeleteByIdCommandHandler(
    UserManager<AppUser> userManager) : IRequestHandler<DeleteUserByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteUserByIdCommand request, CancellationToken cancellationToken)
    {
        AppUser? appUser = await userManager.FindByIdAsync(request.Id.ToString());

        if (appUser is null)
        {
            return Result<string>.Failure("Kullanıcı bulunamadı!");
        }

        appUser.isDeleted = true;

        IdentityResult identityResult = await userManager.UpdateAsync(appUser);

        if (!identityResult.Succeeded)
        {
            return Result<string>.Failure(identityResult.Errors.Select(s => s.Description).ToList());
        }

        return "Kullanıcı başarıyla silindi.";
    }
}
