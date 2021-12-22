using System;

namespace FormationAspNetCoreMVC.Services
{
    public class BinService : IGameConverter
    {
        public string Convert(string s)
        {
            string result = String.Empty;
            foreach (Char c in s)
            {
                result += System.Convert.ToString((int)c, 2);
            }
            return result;
        }
    }
}
