using Microsoft.AspNetCore.Identity;

namespace JomarHealthCare.API
{
    public static class IdentityBuilderExtensions
    {
        public static IdentityBuilder AddTotpTokenProvider(this IdentityBuilder builder)
        {
            var userType = builder.UserType;
            var totpProvider = typeof(TotpTokenProvider);
            return builder.AddTokenProvider("TotpTokenProvider", totpProvider);
        }
    }
}
