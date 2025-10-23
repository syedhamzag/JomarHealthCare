using Microsoft.AspNetCore.Http;
using JomarHealthCare.Application.Abstractions;
using System.Security.Claims;

namespace JomarHealthCare.Infrastructure.Implementations
{
    public class UserIdentityService(IHttpContextAccessor httpContextAccessor) : IUserIdentityService
    {
        public string EmailAddress => GetEmailAddress();

        public string SubjectId => GetNameIdentifier();

        public string PhoneNumber => GetPhoneNumber();

        public Guid CompanyId => GetCompanyId();

        private string GetNameIdentifier()
        {
            var identity = httpContextAccessor.HttpContext!.User.Identity;
            var id = identity as ClaimsIdentity;
            var claim = id!.FindFirst(ClaimTypes.NameIdentifier);// "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress"

            if (claim == null) throw new InvalidOperationException($"{nameof(ClaimTypes.NameIdentifier)} claim is missing");
            return claim.Value;
        }
        private string GetEmailAddress()
        {
            var identity = httpContextAccessor.HttpContext!.User.Identity;
            var id = identity as ClaimsIdentity;
            var claim = id!.FindFirst(ClaimTypes.Email);// "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress"

            if (claim == null) throw new InvalidOperationException($"{nameof(ClaimTypes.Email)} claim is missing");
            return claim.Value;
        }

        private string GetPhoneNumber()
        {
            var identity = httpContextAccessor.HttpContext!.User.Identity;
            var id = identity as ClaimsIdentity;
            var claim = id!.FindFirst(ClaimTypes.MobilePhone);// "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress"

            if (claim == null) throw new InvalidOperationException($"{nameof(ClaimTypes.MobilePhone)} claim is missing");
            return claim.Value;
        }

        private Guid GetCompanyId()
        {
            var identity = httpContextAccessor.HttpContext!.User.Identity;
            var id = identity as ClaimsIdentity;
            var claim = id!.FindFirst("companyid");// "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress"

            if (claim == null) throw new InvalidOperationException("companyid claim is missing");
            return Guid.Parse(claim.Value);
        }
    }
}
