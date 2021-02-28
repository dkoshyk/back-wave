using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Wave.Api.Infrastructure.Data;
using Wave.Api.TaskEndpoints;

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

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(AppSettings.SecretKey)), SecurityAlgorithms.HmacSha256),
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("userLogin", user.Login),
                    new Claim("userId", user.Id.ToString())
                }),
            };
            var jwt = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(jwt);

            response.Result = true;
            response.Login = user.Login;
            response.FullName = user.FirstName + " " + user.LastName;
            response.Token = token;

            return response;
        }
    }
}
