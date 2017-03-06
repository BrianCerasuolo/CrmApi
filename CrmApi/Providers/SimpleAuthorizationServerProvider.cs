using System.Security.Claims;
using CrmApi;
using Microsoft.Owin.Security.OAuth;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MyNamespace
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
#pragma warning disable 1998
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
#pragma warning restore 1998
        {
             context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            IdentityUser user;
            using (AuthRepository repo = new AuthRepository())
            {
                user = await repo.FindUser(context.UserName, context.Password);

                if (user == null)
                {
                    context.SetError("invalid_grant", "The user name or password is incorrect.");
                    return;
                }
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("Name", context.UserName));
            identity.AddClaim(new Claim("UserId", user.Id));
            identity.AddClaim(new Claim("role", "user"));

            context.Validated(identity);

        }
    }
}
