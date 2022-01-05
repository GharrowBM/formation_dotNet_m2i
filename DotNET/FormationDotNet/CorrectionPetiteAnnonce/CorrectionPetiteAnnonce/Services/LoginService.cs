using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;

namespace CorrectionPetiteAnnonce.Services
{
    public class LoginService
    {
        private IRepository<Utilisateur> _utilisateurRepository;

        private IHttpContextAccessor _accessor;

        public LoginService(IRepository<Utilisateur> utilisateurRepository, IHttpContextAccessor accessor)
        {
            _utilisateurRepository = utilisateurRepository;
            _accessor = accessor;
        }

        public bool Login(string login, string password)
        {
            Utilisateur u = _utilisateurRepository.SearchOne(u => u.Login == login && u.Password == password);
            if (u != null)
            {
                _accessor.HttpContext.Session.SetString("isLogged", "true");
                return true;
            }
            return false;
        }

        public bool IsLogged()
        {
            if (bool.TryParse(_accessor.HttpContext.Session.GetString("isLogged"), out bool isLogged))
            {
                if (isLogged)
                {
                    return true;
                }
            }
            return false;
        }

        public string GenerateToken(string login, string password)
        {
            //Verification dans la base de données de l'email et mot de passe
            Utilisateur u = _utilisateurRepository.SearchOne(u => u.Login == login && u.Password == password);
            if (u != null)
            {
                //données à stocker dans le token
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, u.Login),                  
                    new Claim(ClaimTypes.Role, "connected"),
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
