using System;

namespace FormationAspNetCoreMVC.Services
{
    public class ChuckNorrisService : IGameConverter
    {
        public string Convert(string s)
        {
            string bin = String.Empty;
            string chuckNorris = String.Empty;
            foreach (char c in s)
            {
                string l = System.Convert.ToString((int)c, 2);
                if(l.Length < 7)
                {
                    l = new string('0', 7 - l.Length) + l;
                }
                bin += l;
            }
            char lastChar = '\0';
            for(int i = 0; i < bin.Length; i++)
            {
                char current = bin[i];
                if (lastChar != '1' && current == '1')
                {
                    chuckNorris += " 0 0";
                    lastChar = '1';
                }
                else if (lastChar == '1' && current == '1')
                {
                    chuckNorris += "0";
                }
                else if(lastChar != '0' && current == '0')
                {
                    chuckNorris += " 00 0";
                    lastChar = '0';
                }
                else if(lastChar == '0' && current == '0')
                {
                    chuckNorris += "0";
                }
            }
            return chuckNorris;
        }
    }
}
