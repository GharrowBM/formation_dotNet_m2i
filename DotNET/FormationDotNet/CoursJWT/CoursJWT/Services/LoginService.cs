using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace CoursJWT.Services
{
    public class LoginService
    {
        public LoginService()
        {
        }

        public string GenerateToken(string email, string password)
        {
            //Verification dans la base de données de l'email et mot de passe
            if(email == "ihab@utopios.net" && password == "123456")
            {
                //données à stocker dans le token
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Email, "ihab@utopios.net"),
                    new Claim(ClaimTypes.Name, "ihab"),
                    new Claim(ClaimTypes.Role, "admin")
                };

                //Objet pour signer le token
                SigningCredentials signingCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Bonjour je suis la clé de cryptage")), SecurityAlgorithms.HmacSha256);


                //Créer notre jwt
                JwtSecurityToken jwt = new JwtSecurityToken(issuer: "m2i", audience: "m2i", claims: claims, signingCredentials: signingCredentials, expires: DateTime.Now.AddDays(2));
                return new JwtSecurityTokenHandler().WriteToken(jwt);
            }
            return null;
        }
    }
}
