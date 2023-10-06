using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.Entities;
using API.Dtos;
using API.Dtos.Custom;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Persistence;
using System.Security.Cryptography;

namespace API.Services
{
    public class AuthService : IAuthService
    {
        private readonly APIContext _context;
        private readonly IConfiguration _configuration;

        public AuthService(APIContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        private string GenerateToken(string IdUser){
            var key = _configuration.GetValue<string>("JWTSettings:Key");
            var keyBytes = Encoding.ASCII.GetBytes(key);

            var claims = new ClaimsIdentity();
            claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, IdUser));

            var credentialToken = new SigningCredentials(
                new SymmetricSecurityKey(keyBytes),
                SecurityAlgorithms.HmacSha256Signature
            );

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claims,
                Expires = DateTime.UtcNow.AddMinutes(1),
                SigningCredentials = credentialToken
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenConfig = tokenHandler.CreateToken(tokenDescriptor);

            string tokenCreated = tokenHandler.WriteToken(tokenConfig);

            return tokenCreated;
        }

        private string GenerateRefreshToken(){
            var byteArray = new byte[64];
            var refreshToken = "";

            using (var rng = RandomNumberGenerator.Create()){
                rng.GetBytes(byteArray);
                refreshToken = Convert.ToBase64String(byteArray);
            }
            return refreshToken;
        }

        private async Task<AuthResponse> SaveRecordRefreshToken(
            int idUser,
            string token,
            string refreshToken
        ){
            var recordRefreshToken = new RefreshTokenRecord
            {
                IdUser = idUser,
                Token = token,
                RefreshToken = refreshToken,
                CreationDate = DateTime.UtcNow,
                ExpirationDate = DateTime.UtcNow.AddMinutes(2)
            };

            await _context.RefreshTokenRecords.AddAsync(recordRefreshToken);
            await _context.SaveChangesAsync();

            return new AuthResponse{Token = token, RefreshToken = refreshToken, Result = true, Msg = "OK"};
        }

        public async Task<AuthResponse> ReturnToken(AuthRequest auth)
        {
            var userFound = _context.Users.FirstOrDefault(x =>
                x.Username == auth.Username &&
                x.Password == auth.Password
            );

            if(userFound == null){
                return await Task.FromResult<AuthResponse>(null);
            }

            string tokenCreated = GenerateToken(userFound.Id.ToString());

            string refreshTokenCreated = GenerateRefreshToken();

            //return new AuthResponse(){Token = tokenCreated, Result = true, Msg = "OK"};
            return await SaveRecordRefreshToken(userFound.Id, tokenCreated, refreshTokenCreated);
        }

        public async Task<AuthResponse> ReturnRefreshToken(RefreshTokenRequest refreshTokenRequest, int idUser)
        {
            var refreshTokenFound = _context.RefreshTokenRecords.FirstOrDefault(x =>
                x.Token == refreshTokenRequest.ExpiredToken &&
                x.RefreshToken == refreshTokenRequest.RefreshToken &&
                x.IdUser == idUser
            );

            if(refreshTokenFound == null)
                return new AuthResponse {Result = false, Msg = "The Refresh Token doesn´t exist"};
            
            var refreshTokenCreated = GenerateRefreshToken();
            var tokenCreated = GenerateToken(idUser.ToString());

            return await SaveRecordRefreshToken(idUser, tokenCreated, refreshTokenCreated);
        }
    }
}