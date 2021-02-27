using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Annotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Wave.Api.Infrastructure.Data;

namespace Wave.Api.AuthEndpoints
{
    public class Authenticate : BaseAsyncEndpoint
        .WithRequest<AuthenticateRequest>
        .WithResponse<AuthenticateResponse>
    {
        private readonly AppDbContext _dbContext;

        public Authenticate(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("api/authenticate")]
        [SwaggerOperation(
            Summary = "Authenticates a user",
            Description = "Authenticates a user",
            OperationId = "auth.authenticate",
            Tags = new[] { "AuthEndpoints" })
        ]
        public override async Task<ActionResult<AuthenticateResponse>> HandleAsync(AuthenticateRequest request, CancellationToken cancellationToken = default)
        {
            var response = new AuthenticateResponse();

            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Login == request.Login);

            if (user is null)
            {
                return response;
            }

            var passwordSignIn = user.Password == request.Password;

            if (passwordSignIn is false)
            {
                return response;
            }

            var jwt = new JwtSecurityToken(
                    signingCredentials: new SigningCredentials(
                        new SymmetricSecurityKey(Encoding.ASCII.GetBytes(AppSettings.SecretKey)),
                    SecurityAlgorithms.HmacSha256));

            var token = new JwtSecurityTokenHandler().WriteToken(jwt);

            response.Result = true;
            response.Login = user.Login;
            response.FullName = user.FirstName + " " + user.LastName;
            response.Token = token;

            return response;
        }
    }
}
