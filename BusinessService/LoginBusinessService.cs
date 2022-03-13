using System.Collections.Generic;
using TodoApi.BusinessService.Interfaces;
using TodoApi.Models;
using TodoApi.DataService.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;


namespace TodoApi.BusinessService
{
    public class LoginBusinessService : ILoginBusinessService
    {
        private readonly IConfiguration _configuration;
        private ILoginDataService _LoginDataService;

        public LoginBusinessService (ILoginDataService LoginDataService,IConfiguration configuration)
        {   
            _LoginDataService = LoginDataService;
            _configuration = configuration; 
        }
        public string Authentication(User user)
        {
            var UserDataService = _LoginDataService.Login(user);
            bool validation = false;
            if ((UserDataService.UserName == user.UserName) && (UserDataService.Password == user.Password)){
                validation = true;
            }
            if (validation)
            {
                var token = GenerateToken();
                return token;
            }

            return "";
        }
        private string GenerateToken()
        {
            //Header
            var symmetricSecurityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:SecretKey"]));
            var signingCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(symmetricSecurityKey, Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256);
            var header = new JwtHeader(signingCredentials);
            //Claims
            var claims = new[]
            {
                new Claim(ClaimTypes.Actor, "asdfg"),
                new Claim("User", "Bruno"),
            };

            //Payload
            var payload = new JwtPayload
            (
                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                claims,
                System.DateTime.Now,
                System.DateTime.UtcNow.AddMinutes(10)
            );
            var token = new JwtSecurityToken(header, payload);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}