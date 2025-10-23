using Microsoft.AspNetCore.Identity;
using JomarHealthCare.Domain.Entities;

namespace JomarHealthCare.API
{
    public class TotpTokenProvider : TotpSecurityStampBasedTokenProvider<ApplicationUser>
    {
        public override Task<bool> CanGenerateTwoFactorTokenAsync(UserManager<ApplicationUser> manager, ApplicationUser user)
        {
            return Task.FromResult(false);
        }

        public override Task<string> GetUserModifierAsync(string purpose, UserManager<ApplicationUser> manager, ApplicationUser user)
        {
            return base.GetUserModifierAsync(purpose, manager, user);
        }


    }
}
