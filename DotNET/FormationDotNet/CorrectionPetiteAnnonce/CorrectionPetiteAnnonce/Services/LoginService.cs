using System;
using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using Microsoft.AspNetCore.Http;

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
    }
}
