using FormationAspNetCoreMVC.Models;
using System.Collections.Generic;

namespace FormationAspNetCoreMVC.ViewModels
{
    public class PersonneViewModel
    {
        public List<Adresse> Adresses { get; set; }

        public List<Personne> Personnes { get; set; }
    }
}
