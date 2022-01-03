using System;
using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Repositories;
using CorrectionPetiteAnnonce.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CorrectionPetiteAnnonce.Tools
{
    public static class Extension
    {
        public static void AddOurServices(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>();
            services.AddScoped<IRepository<Annonce>, AnnonceRepository>();
            services.AddScoped<IRepository<Utilisateur>, UtilisteurRepository>();
            services.AddTransient<UploadService>();
            services.AddScoped<LoginService>();
            services.AddTransient<FormatService>();
        }
    }
}
