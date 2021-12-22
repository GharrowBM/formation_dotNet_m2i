using System;
using System.Text;

namespace FormationAspNetCoreMVC.Services
{
    public class ToolsService
    {
        private string hash = Guid.NewGuid().ToString();
        public string AlterString(string s)
        {
            string result = "";
            foreach(Char c in s)
            {
                result += Convert.ToString((int)c, 2);
            }
            return result;
        }
    }
}
