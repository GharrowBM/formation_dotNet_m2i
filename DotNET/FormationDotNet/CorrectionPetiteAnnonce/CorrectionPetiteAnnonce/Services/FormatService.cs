using System;
namespace CorrectionPetiteAnnonce.Services
{
    public class FormatService
    {
        public FormatService()
        {
        }

        public string FormatPrice(decimal prix)
        {
            return prix.ToString("0.00");
        }

        public string TextReduction(string text)
        {
            return text.Length > 3 ? text.Substring(0,3)+"..." : text;
        }
    }
}
